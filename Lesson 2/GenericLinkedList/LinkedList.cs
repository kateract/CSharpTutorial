using System;
using System.Collections.Generic;

namespace GenericLinkedList
{//LINQ
    public class LinkedList<T> where T : IComparable<T>
    {

        LinkedListNode head;
        

        public LinkedList () 
        {
            head = null;
        }

        public void Add(T item) {
            if (head == null)
            {
                LinkedListNode node = new LinkedListNode();
                node.item = item;
                head = node;
            } else {
                LinkedListNode current = head;
                while (current.next != null)
                {    
                    current = current.next;
                }
                LinkedListNode node = new LinkedListNode();
                node.item = item;
                current.next = node;
            }
        }

        public T Remove(T item) {
            if (head == null) {
                throw new InvalidOperationException("List has no nodes to remove.");
            }
            else if (head.item.Equals(item))
            {
                head = head.next;
                return item;
            }
            else
            {
                LinkedListNode current = head;
                while(current.next != null && !current.next.item.Equals(item))
                {
                    current = current.next;
                }
                if (current.next != null && current.next.item.Equals(item))
                {
                    current.next = current.next.next;
                    return item;
                }
                else
                {
                    throw new InvalidOperationException("Remove called on non-existing element");
                }
            }
        }

        public void printList() {
            LinkedListNode current = head;
            while (current != null)
            {
                Console.WriteLine(current.item.ToString());
                current = current.next;
            }
            
        }

        private class LinkedListNode
        {
            public LinkedListNode next { get; set; }
            public T item { get; set; }
        }
    }


}