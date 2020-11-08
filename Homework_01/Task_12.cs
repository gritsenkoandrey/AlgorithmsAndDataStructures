using System;


namespace Homework_01
{
    class Task_12
    {
        public int FindingMaximumOfThreeNumbers(int one, int two, int three)
        {
            var result = 0;

            if (one > two && one > three)
            {
                result = one;
            }
            else
            {
                if (two > one && two > three)
                {
                    result = two;
                }
                else
                {
                    result = three;
                }
            }

            return result;
        }
    }
}