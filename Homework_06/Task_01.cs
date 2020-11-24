using System;


namespace Homework_06
{
    static class Task_01
    {
        public static double SimpleHash(string input)
        {
            double res = 0;

            foreach (char item in input)
            {
                res += Math.Log(item);
            }
            return res;
        }
    }
}