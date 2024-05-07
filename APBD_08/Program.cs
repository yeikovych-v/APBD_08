using System;
using LinqTutorials.Models;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1:");
            var t1 = LinqTasks.Task1();
            PrintList(t1);

            Console.WriteLine("Task 2:");
            var t2 = LinqTasks.Task2();
            PrintList(t2);

            Console.WriteLine("Task 3:");
            var t3 = LinqTasks.Task3();
            Console.WriteLine(t3);

            Console.WriteLine("Task 4:");
            var t4 = LinqTasks.Task4();
            PrintList(t4);

            Console.WriteLine("Task 5:");
            var t5 = LinqTasks.Task5();
            PrintList(t5);

            Console.WriteLine("Task 6:");
            var t6 = LinqTasks.Task6();
            PrintList(t6);

            Console.WriteLine("Task 7:");
            var t7 = LinqTasks.Task7();
            PrintList(t7);

            Console.WriteLine("Task 8:");
            var t8 = LinqTasks.Task8();
            Console.WriteLine(t8);

            Console.WriteLine("Task 9:");
            var t9 = LinqTasks.Task9();
            Console.WriteLine(t9);

            Console.WriteLine("Task 10:");
            var t10 = LinqTasks.Task10();
            PrintList(t10);

            Console.WriteLine("Task 11:");
            var t11 = LinqTasks.Task11();
            PrintList(t11);

            Console.WriteLine("Task 12:");
            var t12 = LinqTasks.Task12();
            PrintList(t12);

            Console.WriteLine("Task 13:");
            var t13 = LinqTasks.Task13([1,1,1,1,1,1,10,1,1,1,1,2,2,2]);
            Console.WriteLine(t13);

            Console.WriteLine("Task 14:");
            var t14 = LinqTasks.Task14();
            PrintList(t14);

            Console.WriteLine("Task 15:");
            var t15 = LinqTasks.Task15();
            PrintList(t15);

            Console.WriteLine("Task 16:");
            var t16 = LinqTasks.Task16();
            PrintList(t16);
        }

        private static void PrintList(IEnumerable<object> list)
        {
            
            foreach (var el in list)
            {
                Console.Write(el + ", ");
            }
            Console.WriteLine();
        }
    }
}
