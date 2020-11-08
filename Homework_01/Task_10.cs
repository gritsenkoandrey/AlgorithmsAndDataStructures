using System;


namespace Homework_01
{
    class Task_10
    {
        public bool GetOddNumber()
        {
            int number;

            Console.WriteLine($"Enter a whole number > 0:");
            number = int.Parse(Console.ReadLine());

            if (number % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}