using System;
using System.Threading.Tasks;

namespace HWork01
{
    class Program
    {
        static void MyTask()
        {
            Console.WriteLine("Starting addition thread...");
            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine($"Now is: {i}");
            }
            Console.WriteLine("Addition thread Done!!!");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************");
            Console.WriteLine("        This program show basics use of Multithreading.");
            Console.WriteLine("***************************************************************");
            Console.WriteLine("Starting Main thread...");
            Task task01 = new Task(MyTask);
            task01.Start();
            Console.WriteLine("Ending Main thread...");
            task01.Wait();
        }
    }
}