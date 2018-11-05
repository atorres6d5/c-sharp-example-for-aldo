using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var ll = new LinkedList();

            ll.Push(10).Push(5).Push(40);

            ll.Print();
        }
    }
}
