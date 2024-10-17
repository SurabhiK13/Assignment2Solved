namespace Q6_DivideExcepn_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value for num1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value for num2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = 0;
            try
            {
                num3 = num1 / num2;
                Console.WriteLine(num3);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You are trying to dive by zero please provide int value"); 
            }

        }
    }
}
