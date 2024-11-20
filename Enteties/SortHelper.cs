namespace ClassApp
{
    internal static class SortHelper
    {
        
        public static void SortArray(int[] array, bool ascending)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    bool condition = ascending ? array[j] > array[j + 1] : array[j] < array[j + 1];

                    if (condition)
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}