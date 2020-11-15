namespace Homework_03
{
    class Task_03
    {
        public int FindIndex(int[] arr, int num)
        {
            int minIndex = 0;
            int maxIndex = arr.Length;
            int findIndex = -1;

            Find(minIndex, maxIndex);

            void Find(int min, int max)
            {
                int index = min + (max - min) / 2;
                if (index == max || index == min)
                {
                    return;
                }
                else if (arr[index] == num)
                {
                    findIndex = index;
                    return;
                }
                else if (arr[index] < num)
                {
                    minIndex = index;
                    Find(minIndex, maxIndex);
                }
                else if (arr[index] > num)
                {
                    maxIndex = index;
                    Find(minIndex, maxIndex);
                }
            }
            return findIndex;
        }
    }
}