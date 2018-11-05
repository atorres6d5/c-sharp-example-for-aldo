using System;

namespace test
{
    public class Node
    {
        public int value
        {
            get;
            set;
        }

        public Node next = null;

        public Node(int val)
        {
            value = val;
        }
    }
}
