namespace Question4_FindTheMIddleElement_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list1 = new LinkedList<int>();
            list1.AddLast(10);
            list1.AddLast(20);
            list1.AddLast(30);
            list1.AddLast(40);
            list1.AddLast(50);
            int num = list1.Count;
            num = (num / 2) + 1;
            int x = 0;
            for (LinkedListNode<int> node = list1.First; node != null; node = node.Next)
            {
                x++;
                if (x == num)
                {
                    Console.WriteLine("Middle Element in the Linked List is " + node.Value);
                }
            }
        }
    }
}
