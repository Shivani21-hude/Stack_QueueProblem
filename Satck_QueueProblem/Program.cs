using Satck_QueueProblem;
using System;

namespace Sack_QueueProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Queue using LinkedList \n");
            LinkedListQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            linkedListQueue.Display();
            linkedListQueue.Dequeue();
            linkedListQueue.Display();// this.top=this.top.next
            Console.ReadKey();
        }
    }
}