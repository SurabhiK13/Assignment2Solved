namespace Q10_Tuple_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Tuple<int>,string> dict = new Dictionary<Tuple<int>,string>();
            Tuple<int> t = new Tuple<int>(10);
            //Tuple<int> t2 = new Tuple<int>(120);
            Tuple<int> t3 = new Tuple<int>(80);
            dict.Add(t,"hi");
            dict.Add(t3,"bye");
            foreach (var pair in dict)
            {
                Console.WriteLine(pair);
            }


        }
    }
}
