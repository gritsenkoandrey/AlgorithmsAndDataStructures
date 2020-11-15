namespace Homework_03
{
    class Task_02
    {
        public int[] ShakerSort(int[] arr, out int counter)
        {
            int temp;
            counter = 0;
            int left = 0;
            int right = arr.Length;

            while (right - left >= 0)
            {
                counter++;
                for (int i = left+1; i < right; i++)
                {
                    counter++;
                    if (arr[left] > arr[i])
                    {
                        temp = arr[left];
                        arr[left] = arr[i];
                        arr[i] = temp;
                        counter++;
                    }
                }
                right--;
                for (int j = right; j > left; j--)
                {
                    counter++;
                    if (arr[right] < arr[j])
                    {
                        temp = arr[j];
                        arr[j] = arr[right];
                        arr[right] = temp;
                        counter++;
                    }
                }
                left++;
            }
            return arr;
        }
    }
}