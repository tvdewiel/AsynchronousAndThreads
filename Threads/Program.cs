using System;
using System.Diagnostics;
using System.Threading;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Threaded World!");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            DoStuffThread ds = new DoStuffThread();           
            Thread t1 = new Thread(()=>ds.calculating(10,'1'));
            t1.Start();
           
            Thread t2 = new Thread(() => ds.calculating(10, '2'));
            t2.Start();

            Thread t3 = new Thread(() => ds.calculating(10, '3'));
            t3.Start();

            Thread t4 = new Thread(() => ds.calculating(10, '4'));
            t4.Start();

            Thread t5 = new Thread(() => ds.calculating(10, '5'));
            t5.Start();

            //Thread t6 = new Thread(() => ds.calculating(10, '6'));
            //t6.Start();

            //Thread t7 = new Thread(() => ds.calculating(10, '7'));
            //t7.Start();

            //Thread t8 = new Thread(() => ds.calculating(10, '8'));
            //t8.Start();

            //Thread t9 = new Thread(() => ds.calculating(10, '9'));
            //t9.Start();

            //Thread t10 = new Thread(() => ds.calculating(10, '0'));
            //t10.Start();

            //Thread t11 = new Thread(() => ds.calculating(10, 'a'));
            //t11.Start();

            t3.Join();
            t1.Join();
            t2.Join();
            t4.Join();
            t5.Join();
            //t6.Join();
            //t7.Join();
            //t8.Join();
            //t9.Join();
            //t10.Join();
            //t11.Join();

            //ds.calculating(10, '*');
            stopwatch.Stop();
            Console.WriteLine();
            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
        }
    }
}
