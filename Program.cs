namespace SerachAndSortAlogrithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n 1. Binary Search \n 2. Anagram \n 3. Bubble Sort \n 4. Insertion Sort \n 5. Merge Sort \n 6. Prime Numbers \n 7. Customize Message \n 8. EXIT \n\n Enter the number corresponding to required program : "); var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Write("\n Input a string array (use space between two elements) : "); var array = Console.ReadLine().Split(" ");
                    Console.Write(" Input the element to search in the Array : "); var target = Console.ReadLine();
                    BinarySearch.Search(array, target);
                    Main(args);
                    break;
                case "2":
                    Console.Write("\n Input first word : "); var word1 = Console.ReadLine();
                    Console.Write(" Input second word : "); var word2 = Console.ReadLine();
                    Console.WriteLine(Anagram.Check(word1, word2));
                    Main(args);
                    break;
                case "3":
                    Console.Write("\n Input a string array (use space between two elements) : "); var array1 = Console.ReadLine().Split(" ");
                    BubbleSort.SortStringArray(array1);
                    PrintArray.Print(array1);
                    Main(args);
                    break;
                case "4":
                    Console.Write("\n Input a string array (use space between two elements) : "); var array2 = Console.ReadLine().Split(" ");
                    InsertionSort.SortStringArray(array2);
                    PrintArray.Print(array2);
                    Main(args);
                    break;
                case "5":
                    Console.Write("\n Input a string array (use space between two elements) : "); var array3 = Console.ReadLine().Split(" ");
                    MergeSort.SortStringArray(array3);
                    PrintArray.Print(array3);
                    Main(args);
                    break;
                case "6":
                    Console.Write("\n Input the upper limit for numbers upto which Prime Numbers are required : "); var end = Convert.ToInt32(Console.ReadLine());
                    var primeArray = PrimeNumbers.GetPrimeNumbers(end);
                    PrintArray.Print(primeArray);
                    break;
                case "7":
                    Console.WriteLine();
                    CustomizeMessage.Customize();
                    Main(args);
                    break;
                case "8":
                    break;
                default:
                    Console.WriteLine("\n INVALID INPUT \n");
                    Main(args);
                    break;
            }
        }
    }
}