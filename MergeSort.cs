namespace SerachAndSortAlogrithms
{
    public class MergeSort
    {
        public static int[] SortIntArray(int[] array)
        {
            if (array.Length == 1) return array;

            int mid = array.Length / 2;

            int[] Left = SortIntArray(array[..mid]); 
            int[] Right = SortIntArray(array[mid..]); 

            return MergeInt(Left, Right);
        }

        private static int[] MergeInt(int[] left, int[] right)
        {
            int[] mix = new int[left.Length + right.Length];

            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] < right[j])
                    mix[k++] = left[i++];
                else
                    mix[k++] = right[j++];
            }

            while (i < left.Length)
                mix[k++] = left[i++];

            while (j < right.Length)
                mix[k++] = right[j++];

            return mix;
        }

        public static string[] SortStringArray(string[] array)
        {
            if (array.Length == 1) return array;
            int mid = array.Length / 2;

            string[] Left = SortStringArray(array[..mid]);
            string[] Right = SortStringArray(array[mid..]);

            return MergeString(Left, Right);
        }

        private static string[] MergeString(string[] left, string[] right)
        {
            string[] mix = new string[left.Length + right.Length];

            int i = 0, j = 0, k = 0;
            while (i < left.Length && j < right.Length)
            {
                if (left[i].ToLower().CompareTo(right[j].ToLower()) < 0)
                    mix[k++] = left[i++];
                else
                    mix[k++] = right[j++];
            }

            while (i < left.Length)
                mix[k++] = left[i++];

            while (j < right.Length)
                mix[k++] = right[j++];

            return mix;
        }
    }
}