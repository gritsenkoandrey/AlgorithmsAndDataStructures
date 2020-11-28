using System;


namespace Homework_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = Graph.ReadAndPrint(@"..\..\Matrix.txt", 9);
            Console.WriteLine();
            Console.WriteLine("GraphToWide:");
            int[] res = Graph.GraphToWide(arr, 2, 9);
            foreach (var item in res)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Array.Clear(res, 0, res.Length);
            Console.WriteLine("GraphToDepth:");
            res = Graph.GraphToDepth(arr, 2, 9);
            foreach (var item in res)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Array.Clear(res, 0, res.Length);
            Console.WriteLine("GraphToDepthRecurrent:");
            Graph.GraphToDepthRecurrent(ref arr, ref res, 2, 9);
            Console.WriteLine();
            foreach (var item in res)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}