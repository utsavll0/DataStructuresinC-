using System;

namespace LinkedList
{
    class Program
    {
        Node head;
        class Node
        {
            public int data {get;set;}
            public Node next{get;set;}
            public Node prev{get;set;}
            public Node(int data)
            {
                this.data = data;
                this.next = null;
                this.prev = null;
            }
        }

        static Node AppendNode(Node head,int data)
        {
            Node currentNode = head;
            while(currentNode.next != null)
            {
                currentNode = currentNode.next;
            }
            Node newNode = new Node(data);
            newNode.next = null;
            newNode.prev = currentNode;
            return head;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
