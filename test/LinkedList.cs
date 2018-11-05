using System;
using test;

namespace test
{
    public class LinkedList
    {
        protected int length;
        protected Node head;
        protected Node tail;

        public LinkedList()
        {
            length = 0;
            head = null;
            tail = null;
        }

        public LinkedList Push(int val)
        {
            Node node = new Node(val);
            if (this.length == 0)
            {
                this.head = node;
                this.tail = node;
                this.length += 1;
            }
            else 
            {
                this.tail.next = node;
                this.tail = node;
                this.length += 1;
            }

            return this;  
        }

        public void Print()
        {
            var current = this.head;

            while(current != null)
            {
                Console.WriteLine(current.value);
                current = current.next;
            }
        }
    }
}
