using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Multithreading
{
    class Class
    {
        public void Display()
        {
            Console.WriteLine("implementing thread 1");

            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine("\n {0}", i);
            }
            Console.WriteLine("Thread 1 closes");
        }
        public void Read()
        {
            Console.WriteLine("implementing thread 2");
            for(char j = 'A'; j <= 'Z'; j++)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("thread 2 ends");
        }
    }
}
