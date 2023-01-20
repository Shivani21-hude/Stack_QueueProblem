using Satck_QueueProblem;
using System;

namespace Sack_QueueProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack using LinkedList \n");
            LinkedList linkedListStack = new LinkedList();
            linkedListStack.Push(70);
            linkedListStack.Push(30);
            linkedListStack.Push(56);
            linkedListStack.Display();
           
            Console.ReadKey();
        }
    }
}