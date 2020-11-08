using System;


namespace Homework_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Task_10 task_10 = new Task_10();
            Task_11 task_11 = new Task_11();
            Task_12 task_12 = new Task_12();

            Console.WriteLine(task_10.GetOddNumber());
            task_11.CalculateMean();
            Console.WriteLine($"Maximum number is {task_12.FindingMaximumOfThreeNumbers(-789, 789, 47)}");

            Console.ReadLine();
        }
    }
}