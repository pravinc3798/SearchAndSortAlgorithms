namespace SerachAndSortAlogrithms
{
    public class PrintArray
    {
        public static void Print<T>(T[] array)
        {
            Console.WriteLine();
            foreach (T item in array)
                Console.Write("{0} -> ",item);
            Console.Write("END \n");
        }
    }
}