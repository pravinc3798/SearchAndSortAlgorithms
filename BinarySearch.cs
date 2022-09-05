namespace SerachAndSortAlogrithms
{
    public class BinarySearch
    {
        public static void Search(string[] wordlist, string word)
        {
            InsertionSort.SortStringArray(wordlist);
            var index = WordSearch(wordlist, word, 0, wordlist.Length - 1);

            if (index >= 0)
                Console.WriteLine("'{0}' is Present at index : {1}             // after sorting the array", word, index);
            else
                Console.WriteLine("'{0}' was not Found in the Array", word);
        }
        private static int WordSearch(string[] wordlist, string word, int left, int right)
        {
            if (right < left)
                return -1;

            var mid = (left + right) / 2;

            if (wordlist[mid] == word)
                return mid;

            if (wordlist[mid].ToLower().CompareTo(word.ToLower()) < 0)
                return WordSearch(wordlist, word, mid + 1, right);

            return WordSearch(wordlist, word, left, mid - 1);
        }
    }
}