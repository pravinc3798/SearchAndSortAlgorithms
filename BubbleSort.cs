namespace SerachAndSortAlogrithms
{
    public class BubbleSort
    {
        public static void OptimisedSorting(int[] unsortedArray)
        {
            for (var i = 0; i < unsortedArray.Length; i++)
            {
                var swappingOccured = false;
                for (var j = 1; j < unsortedArray.Length - i; j++) // after each the next largest item bubbles up and hence no need to check bubbled item again and again
                {
                    if (unsortedArray[j] < unsortedArray[j - 1])
                    {
                        Swap(unsortedArray, j, j - 1);
                        swappingOccured = true;                 //after looping over the entire array if no swaping occured then no need to loop from main for loop;
                    }
                }
                if (!swappingOccured)
                    return;
            }
        }

        public static void SortIntArray(int[] unsortedArray)
        {
            for (var i = 0; i < unsortedArray.Length; i++)
                for (var j = 1; j < unsortedArray.Length; j++)
                    if (unsortedArray[j] < unsortedArray[j - 1]) Swap(unsortedArray, j, j - 1);
        }

        public static void SortStringArray(string[] unsortedArray)
        {
            for (var i = 0; i < unsortedArray.Length; i++)
                for (var j = 1; j < unsortedArray.Length; j++)
                    if (unsortedArray[j].ToLower().CompareTo(unsortedArray[j - 1].ToLower()) < 0) Swap(unsortedArray, j, j - 1);
        }


        private static void Swap<T>(T[] array, int index1, int index2)
        {
            (array[index2], array[index1]) = (array[index1], array[index2]);
        }
    }
}