using System;

namespace Homework_06
{
    class Task_02
    {
        static void PrintTree(int i, ref int[] tree)
        {
            if (i < tree.Length && tree[i] != 0)
            {
                Console.Write(tree[i]);
                if ((i * 2 < tree.Length && tree[i * 2] != 0) || (i * 2 + 1 < tree.Length && tree[i * 2 + 1] != 0))
                {
                    Console.Write('(');
                    if (i * 2 < tree.Length && tree[i * 2] != 0)
                    {
                        PrintTree(i * 2, ref tree);
                    }
                    else
                    {
                        Console.Write("NULL");
                    }
                    Console.Write(',');
                    if (i * 2 + 1 < tree.Length && tree[i * 2 + 1] != 0)
                    {
                        PrintTree(i * 2 + 1, ref tree);
                    }
                    else
                    {
                        Console.Write("NULL");
                    }
                    Console.Write(')');
                }
            }
        }

        static void LRRoot(int i, ref int[] tree)
        {
            if (i == 1) Console.WriteLine("LRRoot");
            if (i < tree.Length && tree[i] != 0)
            {
                if (i * 2 < tree.Length && tree[i * 2] != 0)
                {
                    LRRoot(i * 2, ref tree);
                }
                if (i * 2 + 1 < tree.Length && tree[i * 2 + 1] != 0)
                {
                    LRRoot(i * 2 + 1, ref tree);
                }
                Console.Write(tree[i] + " ");
            }
        }

        static void LRootR(int i, ref int[] tree)
        {
            if (i == 1) Console.WriteLine("LRootR");
            if (i < tree.Length && tree[i] != 0)
            {
                if (i * 2 < tree.Length && tree[i * 2] != 0)
                {
                    LRootR(i * 2, ref tree);
                }
                Console.Write(tree[i] + " ");
                if (i * 2 + 1 < tree.Length && tree[i * 2 + 1] != 0)
                {
                    LRootR(i * 2 + 1, ref tree);
                }
            }
        }

        static void RootLR(int i, ref int[] tree)
        {
            if (i == 1) Console.WriteLine("RootLR");
            if (i < tree.Length && tree[i] != 0)
            {
                Console.Write(tree[i] + " ");
                if (i * 2 < tree.Length && tree[i * 2] != 0)
                {
                    LRootR(i * 2, ref tree);
                }
                if (i * 2 + 1 < tree.Length && tree[i * 2 + 1] != 0)
                {
                    LRootR(i * 2 + 1, ref tree);
                }
            }
        }

        static void RootRL(int i, ref int[] tree)
        {
            if (i == 1) Console.WriteLine("RootRL");
            if (i < tree.Length && tree[i] != 0)
            {
                Console.Write(tree[i] + " ");
                if (i * 2 + 1 < tree.Length && tree[i * 2 + 1] != 0)
                {
                    RootRL(i * 2 + 1, ref tree);
                }
                if (i * 2 < tree.Length && tree[i * 2] != 0)
                {
                    RootRL(i * 2, ref tree);
                }
            }
        }

        static int FindN(int n, int[] tree)
        {
            int i = 1;
            while (i < tree.Length)
            {
                if (n == tree[i]) return i;
                if (n < tree[i]) i *= 2;
                else i = 2 * i + 1;
            }
            return -1;
        }
    }
}