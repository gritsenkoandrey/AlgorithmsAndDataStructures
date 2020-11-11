using System;


namespace Homework_02
{
    class Task_02
    {
        static double Pow(double numb, int pow)
        {
            double result = numb;
            if (numb == 0) return 0;
            if (numb == 1 || pow == 0)
                return 1;
            if (pow == 1)
                return numb;
            if (pow < 0)
            {
                pow = Math.Abs(pow);
                while (pow > 1)
                {
                    result *= numb;
                    pow--;
                }
                return 1 / result;
            }
            while (pow > 1)
            {
                result *= numb;
                pow--;
            }
            return result;
        }

        static double RecPow(double numb, int pow)
        {
            if (numb == 0)
                return 0;
            if (numb == 1 || pow == 0)
                return 1;
            if (pow < 0) 
                return 1 / RecPow(numb, Math.Abs(pow));
            else 
                return RecPow(numb, --pow) * numb;
        }

        static double RecPowPary(double numb, int pow)
        {
            if (numb == 0)
                return 0;

            if (numb == 1 || pow == 0)
                return 1;

            if (pow == -1)
                return 1 / numb;

            if (pow > 2 && pow % 2 == 0)
                return RecPowPary(RecPowPary(numb, pow / 2), 2);

            return RecPowPary(numb, pow / 2) * RecPow(numb, pow - pow / 2);
        }
    }
}