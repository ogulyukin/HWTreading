using System;
using System.Threading.Tasks;

namespace HWork01
{
    class Program
    {
        static void MyTask(int begin, int end)
        {
            Console.WriteLine("Starting addition thread...");
            for (int i = begin; i <= end; i++)
            {
                Console.WriteLine($"Now is: {i}");
            }
            Console.WriteLine("Addition thread Done!!!");
        }

        static int getUserInput()
        {
            int result = 0;
            try
            {
                result = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid number was entered!!! Turn it to Zero");
                return 0;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************");
            Console.WriteLine("        This program show basics use of Multithreading.");
            Console.WriteLine("***************************************************************");
            Console.WriteLine("Starting Main thread...");
            int begin, end;
            Console.WriteLine("Enter begin number:");
            begin = getUserInput();
            Console.WriteLine("Enter end number:");
            end = getUserInput();
            Task task01 = new Task(() => MyTask(begin, end));
            task01.Start();
            Console.WriteLine("Ending Main thread...");
            task01.Wait();
        }
    }
}