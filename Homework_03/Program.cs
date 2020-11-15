namespace Homework_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 8, 10, 7, 47, 58, 2, 11, 34 };
            int[] sortArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int counter;

            Task_01 task_01 = new Task_01();
            task_01.BubbleSort(array, out counter);
            task_01.ModifiedBubbleSort(array, out counter);

            Task_02 task_02 = new Task_02();
            task_02.ShakerSort(array, out counter);

            Task_03 task_03 = new Task_03();
            task_03.FindIndex(sortArr, 47);
            task_03.FindIndex(sortArr, 7);
        }
    }
}