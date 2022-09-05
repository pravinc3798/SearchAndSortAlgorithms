namespace SerachAndSortAlogrithms
{
    public class FindYourNumber
    {
        public static void Find()
        {
            Console.WriteLine("\n Find your Guessed Number by answering the question. \n");
            Console.Write("Input the upper limit for numbers : "); var end = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n Gives all answers as Yes or No (Vaild format : Y / y / N / n / Yes / No ) \n");

            var numbers = new int[end];
            for (int i = 0; i < end; i++)
                numbers[i] = i;

            FindWithRecursion(numbers,0, end);
        }
        private static void FindWithRecursion(int[] numbers,int start, int end)
        {
            var mid = (start + end) / 2;

            Console.Write("Is '{0}' Your guessed Number : (y/n) : ", numbers[mid]); var answer = Console.ReadLine();

            if (answer == "Y" || answer == "y" || answer == "Yes" || answer == "yes")
            {
                Console.WriteLine("Voila ! Found your guessed number.");
                return;
            }
            else
            {
                Console.Write("Is your guessed number LESS THAN '{0}' : (y/n) : ", numbers[mid]); var isLessThan = Console.ReadLine();
                if (isLessThan == "Y" || isLessThan == "y" || isLessThan == "Yes" || isLessThan == "yes")
                {
                    FindWithRecursion(numbers,start, mid - 1);
                }
                else
                    FindWithRecursion(numbers, mid + 1, end);
            }
        }
    }
}