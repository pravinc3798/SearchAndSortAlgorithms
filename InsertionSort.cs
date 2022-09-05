namespace SerachAndSortAlogrithms
{
    public class InsertionSort
    {
        public static void SortIntArray(int[] unsortedArray)
        {
            for (var i = 1; i < unsortedArray.Length; i++)
            {
                var current = unsortedArray[i];

                var j = i - 1;
                while (j >= 0 && unsortedArray[j] > current)
                {
                    unsortedArray[j + 1] = unsortedArray[j];
                    j--;
                }

                unsortedArray[j + 1] = current;
            }
        }
        public static void SortStringArray(string[] unsortedArray)
        {
            for (var i = 1; i < unsortedArray.Length; i++)
            {
                var current = unsortedArray[i];

                var j = i - 1;
                while (j >= 0 && unsortedArray[j].ToLower().CompareTo(current.ToLower()) > 0)
                {
                    unsortedArray[j + 1] = unsortedArray[j];
                    j--;
                }

                unsortedArray[j + 1] = current;
            }
        }
    }
}