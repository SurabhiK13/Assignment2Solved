namespace Q7_NullRefExcep_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = null;
            try 
            {
                int len = s.Length;
                Console.WriteLine(len);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Some internal error"); 
            }
        }
    }
}
