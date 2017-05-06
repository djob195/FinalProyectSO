using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOProyect2.Enum;
using System.Threading;
using SOProyect2.Class;

namespace SOProyect2
{
    class ThreadDriver
    {
        const int THREADSDEFAULT = 3;
        public bool Balanced;
        List<Consumer> ConsumersCreated;
        List<Producer> ProducersCreated;
        List<int> ConsumerSUsed;
        List<int> ProducerUsed;
        Queue<ExecutorQuery> waitTransactions;
        Semaphore WaitMutex;

        Scheduler scheduler;

        public ThreadDriver()
        {
            this.ConsumersCreated = new List<Consumer>();
            this.ConsumerSUsed = new List<int>();
            this.ProducersCreated = new List<Producer>();
            this.ProducerUsed = new List<int>();
            this.waitTransactions = new Queue<Class.ExecutorQuery>();
            this.WaitMutex = new Semaphore(1, 1);
            createdProducers(THREADSDEFAULT);
            createConsumers(THREADSDEFAULT);
            Balanced = true;
        }

        public void createScheduler(int bufferSize)
        {
            this.scheduler = new Scheduler(bufferSize);
            foreach (Consumer consumer  in this.ConsumersCreated)
            {
                this.scheduler.setDataConsumer(consumer);
            }
        }

        public void createdProducers(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Producer producer = new Producer(this.ProducersCreated.Count);
                this.ProducersCreated.Add(producer);
            }
        }
        public void createConsumers(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Consumer consumer = new Consumer(this.ConsumersCreated.Count);
                this.ConsumersCreated.Add(consumer);
            }
        }

        public bool isCorrectPrioritys(List<int> prioritys)
        {
            int sum = 0;
            foreach (int priority in prioritys)
            {
                sum += priority;
            }
            return sum == 100;
        }
        public void setSheduler(int maxProducer, int maxConsumer, List<int> prioritys)
        {
            int dif = 0;
            int last = 0;
            if (this.scheduler== null)
            {
                throw new Exception("Error, No se ha definido el tamaño de la cola de transacciones");
            }
            if (!isCorrectPrioritys(prioritys))
            {
                throw new Exception("Error, La suma de las prioridades no es de 100");
            }
            Balanced = false;
            if (maxProducer >this.ProducersCreated.Count)
            {
                dif = maxProducer - this.ProducersCreated.Count;
                createdProducers(dif);
            }
            dif = maxProducer-this.scheduler.CountProducersMax ;
            if (dif > 0)
            {
                List<Producer> producers = new List<Producer>();
                last = 0;
                for (int i = 0; i < dif; i++)
                {
                    for (int j = last; j < this.ProducersCreated.Count; j++)
                    {
                        if (!this.ProducerUsed.Contains(j))
                        {
                            last = j;
                            this.ProducerUsed.Add(j);
                            producers.Add(this.ProducersCreated[j]);
                            break;
                        }
                    }
                }
                this.scheduler.setCountProducers(maxProducer, producers);
            }
            else
            {
                List<int> notUseds = this.scheduler.setCountProducers(maxProducer);
                foreach (int notUsed in notUseds)
                {
                    this.ProducerUsed.Remove(notUsed);
                }
            }
            if (maxConsumer > this.ConsumersCreated.Count)
            {
                dif = maxConsumer - this.ConsumersCreated.Count;
                createConsumers(dif);
            }
            dif = maxConsumer - this.scheduler.CountConsumersMax;
            if (dif > 0)
            {
                List<Consumer> consumers = new List<Consumer>();
                last = 0;
                for (int i = 0; i < dif; i++)
                {
                    for (int j = last; j < this.ConsumersCreated.Count; j++)
                    {
                        if (!this.ConsumerSUsed.Contains(j))
                        {
                            last = j;
                            this.ConsumerSUsed.Add(j);
                            consumers.Add(this.ConsumersCreated[j]);
                            break;
                        }
                    }
                }
                this.scheduler.setCountConsumers(maxConsumer, prioritys, consumers);
            }
            else
            {
                List<int> notUseds = this.scheduler.setCountConsumers(maxConsumer,prioritys,null);
                foreach (int notUsed in notUseds)
                {
                    this.ConsumerSUsed.Remove(notUsed);
                }
            }
            Balanced = true;
        }

        public int getActiveConsumersInt()
        {
            return this.scheduler.getActiveConsumersInt();
        }

        public int getActiveProducersInt()
        {
            return this.scheduler.getActiveProducersInt();
        }

        public void quequeProduce(ExecutorQuery executor)
        {
            this.WaitMutex.WaitOne();
            this.waitTransactions.Enqueue(executor);
            this.WaitMutex.Release();
        }

        public void activeProducer()
        {
            this.scheduler.workProducer(this.waitTransactions.Dequeue());
        }
    }
}
