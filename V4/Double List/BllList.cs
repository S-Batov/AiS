using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_List
{
    internal class BllList
    {
        private Node head;
        private int count;
        public object Count
        {
            get { return count; }
        }
        public BllList()
        {
            head = new Node();
            head.Next = head;
            head.Prev = head;
        }
        private bool IsEmpty()
        {
            if (count == 0) return true;
            return false;
        }
        public void Append(object data)
        {
            Node newNode = new Node(data, head, head.Prev);

            head.Prev.Next = newNode;
            head.Prev = newNode;
            count++;
        }
        private Node Find(object data)
        {
            Node curr = head.Next;
            while (curr != head)
            {
                if (curr.Element.Equals(data))
                    return curr;
                curr = curr.Next;
            }
            return null;
        }
        public void Remove(object data)
        {
            if (count == 0) throw new Exception("Removing from empty list");
            Node curr = head.Next;
            while(curr != head)
            {
                if (curr.Element.Equals(data))
                {
                    curr.Prev.Next = curr.Next;
                    curr.Next.Prev = curr.Prev;
                    count--;
                    break;
                }
                curr = curr.Next;
            }
        }
        public bool Search(object data)
        {
            if (count == 0) throw new Exception("Searching in empty list");
            Node curr = head.Next;
            while (curr != head)
            {
                if (curr.Element.Equals(data))
                    return true;
                curr = curr.Next;
            }
            return false;
        }
        public void Display()
        {
            if (count == 0) throw new Exception("Displaying empty list");
            Node curr = head.Next;
            while (curr != head)
            {
                Console.WriteLine(curr.Element.ToString() + " ");
                curr = curr.Next;
            }
            Console.WriteLine();
        }
    }
}
