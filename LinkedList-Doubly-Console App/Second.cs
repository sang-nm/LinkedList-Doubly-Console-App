using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondSet
{
    class Node
    {
        public Node(object data, Node next, Node previous)
        {
            this.data = data;
            this.next = next;
            this.previous = previous;
        }

        private object data;

        public object Data
        {
            get { return data; }
            set { data = value; }
        }

        private Node next;

        public Node Next
        {
            get { return next; }
            set { next = value; }
        }

        private Node previous;

        public Node Previous
        {
            get { return previous; }
            set { previous = value; }
        }
    }
    class LinkedList_Doubly
    {
        Node Start;
        //Node newNode;

        public void InsertNode(object item)
        {
            //newNode = new Node(item, null, null);
            if (Start == null)
            {
                Start = new Node(item, null, null);
            }
            else if (Convert.ToInt32(item) < Convert.ToInt32(Start.Data))
            {
                Start.Previous = new Node(item, Start, null);
                Start = Start.Previous;
            }
            else
            {
                Node CurrentNode = Start;
                Node PreviousNode = null;
                while (CurrentNode != null && Convert.ToInt32(CurrentNode.Data) <= Convert.ToInt32(item))
                {
                    PreviousNode = CurrentNode;
                    CurrentNode = CurrentNode.Next;
                }
                if (!PreviousNode.Data.Equals(item))
                {
                    PreviousNode.Next = new Node(item, CurrentNode, PreviousNode);
                }
            }
        }

        public void DeleteNode(object item)
        {
            Node DelNode = new Node(item, null, null);
            DelNode.Data = item;
            if (Start == null)
            {
                Console.WriteLine("Nothing");
            }
            else
            {
                Node CurrentNode = Start;
                Node PreviousNode = null;
                while (CurrentNode != null && !CurrentNode.Data.Equals(item))
                {
                    PreviousNode = CurrentNode;
                    CurrentNode = CurrentNode.Next;
                }
                if (CurrentNode == null)
                {
                    Console.WriteLine("Nothing to del :" + item);
                }
                else
                {
                    if (PreviousNode == null)
                    {
                        Start = Start.Next;
                        Start.Previous = null;
                    }
                    else
                    {
                        PreviousNode.Next = CurrentNode.Next;
                        if (CurrentNode.Next != null)
                        {
                            CurrentNode.Next.Previous = PreviousNode;
                        }
                    }
                }
            }
        }

        public void Traverse()
        {
            Node CurrentNode = Start;
            while (CurrentNode != null)
            {
                Console.WriteLine(CurrentNode.Data);
                CurrentNode = CurrentNode.Next;
            }
        }

        public void Pretravel()
        {
            Node CurrentNode = Start;
            while (CurrentNode.Next != null)
            {
                CurrentNode = CurrentNode.Next;
            }
            while (CurrentNode != null)
            {
                Console.WriteLine(CurrentNode.Data);
                CurrentNode = CurrentNode.Previous;
            }
        }
    }
}
