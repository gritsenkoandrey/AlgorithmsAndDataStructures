namespace Homework_03
{
    class Task_01
    {
        public int [] BubbleSort(int[] array, out int counter)
        {
            int temp;
            counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                counter++;
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    counter++;
                    if (array[j] > array[j+1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                        counter++;
                    }
                }
            }
            return array;
        }

        public int[] ModifiedBubbleSort(int[] array, out int counter)
        {
            int temp;
            counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                counter++;
                for (int j = 0; j < array.Length; j++)
                {
                    counter++;
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                        counter++;
                    }
                }
            }
            return array;
        }
    }
}