using System;

namespace Homework_05
{
    public static class Task_01
    {
        public static Binary ConvertDecimalToBinary(int decNumb)
        {
            Binary binNumb = new Binary();
            MyStack<bool> stack = new MyStack<bool>();
            int temp;
            if (decNumb == 0) return binNumb;
            if (decNumb > 0)
            {
                temp = decNumb;
                for (int i = 0; i < binNumb.Length; i++)
                {
                    stack.Push(temp % 2 == 1);
                    temp /= 2;
                }
            }
            if (decNumb < 0)
            {
                temp = Math.Abs(decNumb + 1);
                for (int i = 0; i < binNumb.Length; i++)
                {
                    stack.Push(temp % 2 == 0);
                    temp /= 2;
                }
            }
            for (int i = 0; i < binNumb.Length; i++)
            {
                binNumb.cat[i] = stack.Pop();
            }
            return binNumb;
        }
    }

    public class Binary
    {
        public bool[] cat;
        public int Length { get; private set; }
        public Binary(int length = 32)
        {
            Length = length;
            cat = new bool[Length];
        }

        public override string ToString()
        {
            string str = "";
            bool flag = false;
            for (int i = 0; i < cat.Length / 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (!flag && !cat[i * 4 + j] && i != cat.Length / 4 - 1) continue;
                    else flag = true;
                }
                if (flag)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        if (cat[i * 4 + k]) str += 1;
                        else str += 0;
                    }
                    str += " ";
                }
            }
            if (!flag) str += 0;
            return str;
        }
    }
}