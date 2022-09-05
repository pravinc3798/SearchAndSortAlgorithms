using System.Collections;

namespace SerachAndSortAlogrithms
{
    public class Anagram
    {
        public static string Check(string one, string two)
        {
            var charArray1 = one.ToArray();
            var charArray2 = two.ToArray();

            Array.Sort(charArray2);
            Array.Sort(charArray1);
            
            string result = charArray1.SequenceEqual(charArray2) ? "Anagram" : "Not Anagram";
            return result;
        }
    }
}