using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_List
{
    internal class List
    {
        private Node head;
        private Node tail;
        public List() {
            head = null;
            tail = null;
        }
        public bool IsEmpty() {  return head == null; }
        public void InsertFront(object data)
        {
            Node newElem = new Node(data, this.head);
            if (IsEmpty())
            {
                tail = newElem;
            }
            head = newElem;
        }
        public void InsertEnd(object data)
        {
            Node newElem = new Node(data, null);
            if(IsEmpty())
            {
                head = newElem;
                tail = newElem;
            }
            tail.Next = newElem;
            tail = newElem;
        }
        public void RemoveFront()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("List is empty");
            }
            head = head.Next;
        }

        public void RemoveEnd()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("List is empty");
            }
            Node curr = head;
            if(curr.Next == null)
            {
                head = null;
                tail = null;
            }
            while(curr.Next.Next != null)
            {
                curr = curr.Next;
            }
            curr.Next = null;
            tail = curr;
        }

        public void Display()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Display: List is empty");
            }
            Node curr = head;
            while (curr != null)
            {
                Console.WriteLine("Data: " + curr.Element);
                curr = curr.Next;
            }
        }
    }
}
