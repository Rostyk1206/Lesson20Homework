using System;

namespace Lesson20Homewrok3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList<int> arrayList = new ArrayList<int>();
            arrayList.Enqueue(9);
            arrayList.Enqueue(2);
            arrayList.Enqueue(5);
            arrayList.Enqueue(7);
            arrayList.Enqueue(0);
            Console.WriteLine(arrayList.Contains(9));
            Console.WriteLine(arrayList.Contains(3));
            
            MyStack<int> myStack = new MyStack<int>();
            myStack.Push(9);
            myStack.Push(2);
            myStack.Push(5);
            myStack.Push(7);
            myStack.Push(0);
            Console.WriteLine(myStack.Contains(9));
            Console.WriteLine(myStack.Contains(3));




        }
    }
}
