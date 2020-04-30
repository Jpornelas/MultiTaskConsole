using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aqui a task é executada e o código segue sem esperar sua conclusão
            Task t = Task.Run(() =>
            {
                AddOne();
            });


            //Aqui as tasks são executadas em paralelo e o código segue após a conclusão das mesmas
            Console.WriteLine("Começo das tasks!");
            Parallel.Invoke(() =>
            {
                AddTwo();
            },
            () =>
            {
                AddThree();
            });
            Console.WriteLine("Fim das tasks!");

            Console.ReadKey();

        }
        private static void AddOne()
        {
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("Task One");
                //listBox1.Items.Add("Task One");
                Thread.Sleep(1000);
            }
        }
        private static void AddTwo()
        {
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Task Two");
                //listBox2.Items.Add("Task Two");
                Thread.Sleep(2000);
            }
        }
        private static void AddThree()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Task Three");
                //listBox3.Items.Add("Task Three");
                Thread.Sleep(3000);
            }
        }
    }
}
