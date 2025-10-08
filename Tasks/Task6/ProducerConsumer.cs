using System;
using System.Collections.Generic;
using System.Threading;

class ProducerConsumer
{
    static Queue<int> buffer = new Queue<int>();
    static int bufferSize = 5;
    static object lockObject = new object();

    public  static void main()
    {
        Thread producer1 = new Thread(Produce);
        Thread producer2 = new Thread(Produce);
        Thread consumer1 = new Thread(Consume);
        Thread consumer2 = new Thread(Consume);

        producer1.Start();
        producer2.Start();
        consumer1.Start();
        consumer2.Start();
    }

    static void Produce()
    {
        while (true)
        {
            lock (lockObject)
            {
                while (buffer.Count >= bufferSize)
                {
                    Monitor.Wait(lockObject);// to avoid deadlock while waiting
                }
                int item = new Random().Next(100); 
                buffer.Enqueue(item);
                Console.WriteLine($"Produced: {item}");
                Monitor.PulseAll(lockObject);
            }
            Thread.Sleep(new Random().Next(500)); 

        }
    }

    static void Consume()
    {
        while (true)
        {
            int item;
            lock (lockObject)
            {
                while (buffer.Count == 0)
                {
                    Monitor.Wait(lockObject);
                }
                item = buffer.Dequeue();
                Console.WriteLine($"    Consumed: {item}");
                Monitor.PulseAll(lockObject);
            }
            Thread.Sleep(new Random().Next(1000));
        }
    }
}
    