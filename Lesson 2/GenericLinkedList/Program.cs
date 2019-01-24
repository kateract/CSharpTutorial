using System;

namespace GenericLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();
            list.Add("Hello");
            list.Add("World");
            list.Add("World");

            list.printList();

            list.Remove("World");
            list.printList();

        }
    }
}
