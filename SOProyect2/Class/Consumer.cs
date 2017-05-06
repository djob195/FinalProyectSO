using SOProyect2.Class;
using SOProyect2.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace SOProyect2
{
    class Consumer
    {
        public int ID;
        private int Priority;
        StatusWorker Status;

        List<Consumer> Consumers;
        Stack<Consumer> ConsumersFree;

        private Semaphore Empty;
        private Semaphore Full;
        private Semaphore MutexConsumer;
        private Semaphore MutexTransactions;

        private ExecutorQuery ExecutorQuery;

        private int SizeTransactions;

        private Queue<ExecutorQuery> Transactions;

        Thread Thread;

        private void addWorkersFree()
        {
            this.Status = StatusWorker.free;
            this.MutexConsumer.WaitOne();
            if (this.Consumers.Count > 1 || this.Transactions.Count==0)
            {
                this.Consumers.Remove(this);
                this.ConsumersFree.Push(this);
            }
            else
            {
                int dif = this.ConsumersFree.Count;
                if ((this.ConsumersFree.Count + 1) >= this.Transactions.Count)
                {
                    this.rework();
                    dif -= this.Transactions.Count-1;
                }
                for (int i = 0; i < dif; i++)
                {
                    Consumer consumer = this.ConsumersFree.Pop();
                    consumer.rework();
                    this.Consumers.Add(consumer);
                }
            }
            this.MutexConsumer.Release();
        }

        private void nothing() { }
        private void consume()
        {
            this.Status = StatusWorker.sleep;
            this.Full.WaitOne();
            this.MutexTransactions.WaitOne();
            this.ExecutorQuery = this.Transactions.Dequeue();
            this.Status = StatusWorker.process;
            try
            {
                this.ExecutorQuery.executeQuery();
            }
            catch (Exception)
            {
                this.Transactions.Enqueue(this.ExecutorQuery);
            }
            if (this.Transactions.Count == 0)
            {
                for (int i = 0; i < this.SizeTransactions; i++)
                {
                    this.Empty.Release();
                }
            }
            this.MutexTransactions.Release();
            addWorkersFree();
        }
        public void setSemaphores(ref Semaphore empty, ref Semaphore full, ref Semaphore mutexConsumer, ref Semaphore mutexTransactions)
        {
            this.Empty = empty;
            this.Full = full;
            this.MutexConsumer = mutexConsumer;
            this.MutexTransactions = mutexTransactions;
        }

        public void setStructs(ref List<Consumer> consumers, ref Stack<Consumer> consumersFree, ref Queue<ExecutorQuery> transactions)
        {
            this.Consumers = consumers;
            this.ConsumersFree = consumersFree;
            this.Transactions = transactions;
        }

        public void setCounts(int sizeTransactions)
        {
            this.SizeTransactions = sizeTransactions;
        }
        public void recicleThread()
        {
            this.Status = StatusWorker.sleep;
            ThreadStart ts = new ThreadStart(consume);
            this.Thread = new Thread(ts);
            this.Thread.Name = "Consumer " + ID;
            this.Thread.Start();
        }
        public Consumer(int id)
        {
            this.ID = id;
            this.Status = StatusWorker.free;
            ThreadStart ts = new ThreadStart(nothing);
            this.Thread = new Thread(ts);
            this.Thread.Name = "Producer " + this.ID;
        }

        public void setPriority(int priority)
        {
            this.Priority = priority;
        }

        public void rework()
        {
            recicleThread();
        }

        public string[] getDataWorker()
        {
            string[] data = new string[2]; 
            string nameThread = this.Thread.Name;
            string stateThread = Scheduler.getStatusString(this.Status);
            if (this.Status != StatusWorker.free)
            {
                if (this.ExecutorQuery != null)
                {
                    nameThread += " " + this.ExecutorQuery.getData();
                }
            }
            data[0] = nameThread;
            data[1] = stateThread;
            return data;
        }
    }
}
