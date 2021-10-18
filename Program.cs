using System;
using System.Threading;
using System.Threading.Tasks;

namespace Demo_Multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementing multithreading!");

            Class History = new Class();
            Console.WriteLine("Main Thread started..");
            History.Display();

            ThreadStart th1 = History.Display;
            ThreadStart th2 = History.Read;

            Thread thread1 = new Thread(th1);
            Thread thread2 = new Thread(th2);

            thread1.Start();
            thread2.Start();

            Console.WriteLine("Main thread ends here");
            Console.ReadKey();

        }
    }
}
