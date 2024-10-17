namespace Question3_MergedSortLinkedList_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list1 = new LinkedList<int>();
            list1.AddLast(80);
            list1.AddLast(40);
            list1.AddLast(30);
            list1.AddLast(50);
            list1.AddLast(90);
            
            LinkedList<int> list2 = new LinkedList<int>();
            list2.AddFirst(10);
            list2.AddFirst(60);
            list2.AddFirst(20);
            list2.AddFirst(100);
            list2.AddFirst(70);

           LinkedList<int> list3 = new LinkedList<int>();
            foreach (var item in list1)
            {
                list3.AddFirst(item);
            }
            foreach (var item in list2)
            {
                list3.AddFirst(item);
            }
            foreach (var item in list3.Order())
            {
                Console.WriteLine(item);
            }
        }
    }
}
