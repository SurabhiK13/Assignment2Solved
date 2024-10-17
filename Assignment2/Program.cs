namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<double> doubleStack = new Stack<double>();
            doubleStack.Push(21.05);
            doubleStack.Push(57.123);
            doubleStack.Push(765.912);
            doubleStack.Push(43.65);
            Console.WriteLine("peeked value before the first pop : " + doubleStack.Peek());
            Console.WriteLine("Last element = "+ doubleStack.Pop());
            doubleStack.Pop();
            doubleStack.Pop();
            Console.WriteLine("peeked value before the last pop :" + doubleStack.Peek());
            Console.WriteLine("First element = " + doubleStack.Pop());
            



        }
    }
}
