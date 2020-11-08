using System;


namespace Homework_01
{
    class Task_11
    {
        public void CalculateMean()
        {
            int number;
            int counter = 0;
            int sum = 0;
            double mean = 0;

            do
            {
                Console.WriteLine($"Enter number in the range 1 - {int.MaxValue}, to count type 0");
                number = int.Parse(Console.ReadLine());
                if (number > 0 && number % 10 == 8)
                {
                    counter++;
                    sum += number;
                }
            } while (number != 0);

            mean = sum / counter;

            Console.WriteLine($"Mean is {mean}, counter is {counter}");
        }
    }
}