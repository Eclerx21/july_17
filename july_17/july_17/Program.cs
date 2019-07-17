using System;

namespace july_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ");
        }
            
    }
        class Node
        {
            Node nextLink;
            Node prevLink;
            String nodeName;
            internal Node nextLink;

        }
    class LinkedList
    {
        Node Head, Orange, Tangerine, Tail;
        public void CreateLinkedList()
        {
            Head = new Node();
            Orange = new Node();
            Tangerine = new Node();
            Tail = Tangerine;
            Head.nextLink =  Orange;
            Console.WriteLine("yeahh!!");
        }
    }

}
    
