namespace Question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> listBeforeRevese = new LinkedList<int>();
            listBeforeRevese.AddLast(10);
            listBeforeRevese.AddLast(20);
            listBeforeRevese.AddLast(30);
            listBeforeRevese.AddLast(40);
            listBeforeRevese.AddLast(50);
            Console.WriteLine("Linked List Before Reversing");
            foreach (int i in listBeforeRevese)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            LinkedList<int> reversedList = new LinkedList<int>();
            reversedList.AddFirst(10);
            reversedList.AddFirst(20);
            reversedList.AddFirst(30);
            reversedList.AddFirst(40);
            reversedList.AddFirst(50);
            Console.WriteLine("Linked List After Reversing");
            foreach (int i in reversedList)
            {
                Console.WriteLine(i);
            }

        }
    }
}
