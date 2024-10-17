namespace Q9_OverFlowExcep_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a num");
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num);
            }
            catch(OverflowException) 
            {
                Console.WriteLine("Kindly provide integer value (string/long value not allowed)");
            }
        }
    }
}
