namespace Q8_IndexExcep_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Enter an index 0 to 4 ");

            try
            {
                int index = int.Parse(Console.ReadLine());
                Console.WriteLine("Element at index " + index + ": " + arr[index]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index is out of range");
            }
        }
    }
}
