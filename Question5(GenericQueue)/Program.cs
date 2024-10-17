namespace Question5_GenericQueue_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<double> list1 = new LinkedList<double>();
            list1.AddLast(10.87);
            list1.AddLast(20.34);
            list1.AddLast(30.84);
            list1.AddLast(40.62);
            list1.AddLast(50.21);
            
            Queue<double> queue = new Queue<double>(list1);
            {
                foreach (var item in queue)
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}
