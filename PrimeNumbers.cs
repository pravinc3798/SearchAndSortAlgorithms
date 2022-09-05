namespace SerachAndSortAlogrithms
{
    public class PrimeNumbers
    {
        public static int[] GetPrimeNumbers(int range)
        {
            var primeNumbersList = new List<int>();

            for (int i = 2; i <= range; i++)
            {
                var shouldAdd = 0;
                for (int j = 2; j < i / 2 + 1; j++)
                {
                    if (i % j == 0)
                        shouldAdd = 1;
                }
                if (shouldAdd == 0)
                    primeNumbersList.Add(i);
            }

            int[] primeNumbers = primeNumbersList.ToArray();

            return primeNumbers;
        }
    }
}