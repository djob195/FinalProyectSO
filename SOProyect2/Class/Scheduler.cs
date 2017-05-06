using SOProyect2.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SOProyect2.Class
{
    class Scheduler
    {
        bool flagOkCountProducers;
        bool flagOkCountConsumers;

        Semaphore Full;
        Semaphore Empty;
        Semaphore MutexTransactions;
        Semaphore MutexConsumers;
        Semaphore MutexProducers;
        Semaphore MutexWait;

        public int CountConsumersMax;
        public int CountProducersMax;
        public int CountTransactionsMax;

        List<Consumer> Consumers;
        List<Producer> Producers;

        Stack<Consumer> ConsumersFree;
        Stack<Producer> ProducersFree;

        Queue<ExecutorQuery> Transactions;
        Queue<ExecutorQuery> WaitTransactions;

        public Scheduler(int counTransactionsMax)
        {
            this.CountTransactionsMax = counTransactionsMax;
            Full = new Semaphore(counTransactionsMax, counTransactionsMax);
            for (int i = 0; i < counTransactionsMax; i++)
            {
                Full.WaitOne();
            }
            Empty = new Semaphore(counTransactionsMax, counTransactionsMax);
            MutexConsumers = new Semaphore(1, 1);
            MutexProducers = new Semaphore(1, 1);
            MutexTransactions = new Semaphore(1, 1);
            MutexWait = new Semaphore(1, 1);
            Consumers = new List<Consumer>();
            Producers = new List<Producer>();
            ConsumersFree = new Stack<Consumer>();
            ProducersFree = new Stack<Producer>();
            Transactions = new Queue<ExecutorQuery>(counTransactionsMax);
        }

        public void setDataConsumer(Consumer newConsumer)
        {
            newConsumer.setCounts(this.CountTransactionsMax);
            newConsumer.setSemaphores(ref this.Empty, ref this.Full,ref this.MutexConsumers,ref this.MutexTransactions);
            newConsumer.setStructs(ref this.Consumers, ref this.ConsumersFree, ref this.Transactions);
        }

        public void setDataProducer(Producer newProducer)
        {
            newProducer.setCounts(this.CountTransactionsMax);
            newProducer.setSemaphores(ref this.Empty, ref this.Full, ref this.MutexConsumers, ref this.MutexTransactions, ref MutexWait);
            newProducer.setStructs(ref this.Producers, ref this.ProducersFree, ref this.Transactions, ref this.WaitTransactions);
        }

        public void workProducer(ExecutorQuery executor)
        {
            if (this.ProducersFree.Count == 0)
            {
                MutexWait.WaitOne();
                this.WaitTransactions.Enqueue(executor);
                MutexWait.Release();
            }
            else
            {
                this.MutexProducers.WaitOne();
                Producer producer = this.ProducersFree.Pop();
                producer.reWork(executor);
                this.Producers.Add(producer);
                this.MutexProducers.Release();
            }

        }

        public List<int> setCountConsumers(int countConsumerMax, List<int> prioritys,List<Consumer> consumers = null)
        {
            List<int>notUseds = null;
            int j = 0;
            while (this.ConsumersFree.Count != this.CountConsumersMax) { };
            MutexConsumers.WaitOne();
            if (countConsumerMax>this.CountConsumersMax)
            {
                foreach (Consumer consumer in consumers)
                {
                    this.ConsumersFree.Push(consumer);
                }
            }
            else
            {
                int dif = this.CountConsumersMax - countConsumerMax;
                for (int i = 0; i < dif; i++)
                {
                    notUseds.Add(this.ConsumersFree.Pop().ID);
                }
            }
            foreach (Consumer consumer in ConsumersFree)
            {
                consumer.setPriority(prioritys[j]);
                j++;
            }
            this.CountConsumersMax = countConsumerMax;
            MutexConsumers.Release();
            return notUseds;
        }

        public List<int> setCountProducers(int countProducersMax, List<Producer> producers = null)
        {
            List<int> notUseds = null;
            int j = 0;
            while (this.ProducersFree.Count != this.ProducersFree.Count) { };
            MutexProducers.WaitOne();
            if (countProducersMax > this.CountProducersMax)
            {
                foreach (Producer producer in producers)
                {
                    this.ProducersFree.Push(producer);
                }
            }
            else
            {
                int dif = this.CountProducersMax - countProducersMax;
                for (int i = 0; i < dif; i++)
                {
                    notUseds.Add(this.ProducersFree.Pop().ID);
                }
            }
            this.CountProducersMax = countProducersMax;
            MutexProducers.Release();
            return notUseds;
        }

        public int getActiveConsumersInt()
        {
            return this.Consumers.Count + this.ConsumersFree.Count;
        }

        public int getActiveProducersInt()
        {
            return this.Producers.Count + this.ProducersFree.Count;
        }
        public static string getStatusString(StatusWorker status)
        {
            switch (status)
            {
                case StatusWorker.process:
                    return "Procesando";
                case StatusWorker.free:
                    return "Libre";
                case StatusWorker.sleep:
                    return "Dormido";
                default:
                    return "";
            }
        }

    }
}
