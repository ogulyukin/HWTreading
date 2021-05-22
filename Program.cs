using System;
using System.Threading.Tasks;

namespace HWork01
{
    class Program
    {
        static void MyTask(int begin, int end, int index)
        {
            Console.WriteLine($"Starting addition thread {index}");
            for (int i = begin; i <= end; i++)
            {
                Console.WriteLine($"Now {index} is : {i}");
            }
            Console.WriteLine($"Addition thread {index} Done!!!");
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

        static void TaskStarter(ref Task task, int begin, int end, int index)
        {
            task = new Task(() => MyTask(begin, end, index));
            task.Start();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************");
            Console.WriteLine("        This program show basics use of Multithreading.");
            Console.WriteLine("***************************************************************");
            Console.WriteLine("Starting Main thread...");
            int begin, end, NumberOfThread;
            Console.WriteLine("Enter begin number:");
            begin = getUserInput();
            Console.WriteLine("Enter end number:");
            end = getUserInput();
            Console.WriteLine("Enter number of threads:");
            NumberOfThread = getUserInput();
            if (NumberOfThread == 0)
            {
                Console.WriteLine("Nothing to do.");
                return;
            }

            Task[] task = new Task[NumberOfThread];
            for (int i = 0; i < NumberOfThread; i++)
            {
                TaskStarter(ref task[i], begin, end, i);
            }
            Console.WriteLine("Ending Main thread...");
            Task.WaitAll(task);
        }
    }
}