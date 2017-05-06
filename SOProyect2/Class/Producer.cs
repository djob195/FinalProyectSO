using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOProyect2.Enum;
using SOProyect2.Class;
using System.Threading;

namespace SOProyect2
{
    class Producer
    {
        public int ID;
        ExecutorQuery ExecutorQuery;
        Thread Thread;
        StatusWorker Status;

        private Semaphore Empty;
        private Semaphore Full;
        private Semaphore MutexProducer;
        private Semaphore MutexTransactions;

        List<Producer> Producers;
        Stack<Producer> ProducersFree;

        private Queue<ExecutorQuery> Transactions;
        private Queue<ExecutorQuery> WaitTransactions;

        private int CountRegisters;
        private int SizeTransactions;


        public void nothing() { }

        private void addWorkersFree()
        {
            this.MutexProducer.WaitOne();
            if (WaitTransactions.Count != 0)
            {
                this.reWork(this.WaitTransactions.Dequeue());
            }
            else
            {
                this.Status = StatusWorker.free;
                this.Producers.Remove(this);
                this.ProducersFree.Push(this);
            }
            this.MutexProducer.Release();
        }
        public void produce()
        {
            for (int i = 0; i < this.ExecutorQuery.Register; i++)
            {
                this.Status = StatusWorker.sleep;
                this.Empty.WaitOne();
                this.MutexTransactions.WaitOne();
                this.Status = StatusWorker.process;
                this.Transactions.Enqueue(this.ExecutorQuery);
                this.CountRegisters++;
                if (this.SizeTransactions == this.Transactions.Count)
                {
                    for (int j = 0; j < this.SizeTransactions; j++)
                    {
                        this.Full.Release();
                    }
                }
                this.MutexTransactions.Release();
            }
            this.CountRegisters = 0;
            addWorkersFree();
        }

        public void setSemaphores(ref Semaphore empty,ref Semaphore full, ref Semaphore mutexProducer, ref Semaphore mutexTransactions)
        {     
            this.Empty = empty;
            this.Full = full;
            this.MutexProducer = mutexProducer;
            this.MutexTransactions = mutexTransactions;
        }

        public void setStructs(ref List<Producer> producers, ref Stack<Producer> producersFree,
            ref List<Consumer> consumers, ref Stack<Consumer> consumersFree,
            ref Queue<ExecutorQuery> transactions, ref Queue<ExecutorQuery> waitTransactions)
        {
            this.Producers = producers;
            this.ProducersFree = producersFree;
            this.Transactions = transactions;
            this.WaitTransactions = waitTransactions;
        }

        public void setCounts(int sizeTransactions)
        {
            this.SizeTransactions = sizeTransactions;
        }
        public void recicleThread()
        {
            this.Status = StatusWorker.sleep;
            ThreadStart ts = new ThreadStart(produce);
            this.Thread = new Thread(ts);
            this.Thread.Name = "Producer " + ID;
            this.Thread.Start();
        }

        public Producer(int id)
        {
            this.ID = id;
            this.Status = StatusWorker.free;
            ThreadStart ts = new ThreadStart(nothing);
            this.Thread = new Thread(ts);
            this.Thread.Start();
        }

        public void reWork(ExecutorQuery executorQuery)
        {
            this.ExecutorQuery = executorQuery;
            this.recicleThread();
        }

        public string[] getDataWorker()
        {
            string[] data = new string[3];
            string nameThread = this.Thread.Name;
            string stateThread = Scheduler.getStatusString(this.Status);
            if (this.Status != StatusWorker.free)
            {
                if (this.ExecutorQuery != null)
                {
                    nameThread += " " + this.ExecutorQuery.getData();
                }
            }
            data[2] = (this.Status != StatusWorker.free) ? this.CountRegisters + " de " + this.ExecutorQuery.Register : "-";
            data[0] = nameThread;
            data[1] = stateThread;
            return data;
        }
    }
}
