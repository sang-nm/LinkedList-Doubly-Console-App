using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSet
{
    class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
        public Node Previous { get; set; }
    }
    class LinkedList_Doubly
    {
        Node Start;
        Node newNode;

        public void InsertNode(int item)
        {
            newNode = new Node();
            newNode.Data = item;
            if (Start == null)
            {
                Start = newNode;
            }
            else if (item < Start.Data)
            {
                newNode.Next = Start;
                Start.Previous = newNode;
                Start = newNode;
            }
            else
            {
                Node CurrentNode = Start;
                Node PreviousNode = null;
                while (CurrentNode != null && CurrentNode.Data <= item)
                {
                    PreviousNode = CurrentNode;
                    CurrentNode = CurrentNode.Next;
                }
                if (PreviousNode.Data != item)
                {
                    PreviousNode.Next = newNode;
                    newNode.Previous = PreviousNode;
                    if (CurrentNode != null)
                    {
                        CurrentNode.Previous = newNode;
                    }
                    newNode.Next = CurrentNode;
                }
            }
        }

        public void DeleteNode(int item)
        {
            Node DelNode = new Node();
            DelNode.Data = item;
            if (Start == null)
            {
                Console.WriteLine("Nothing");
            }
            else
            {
                Node CurrentNode = Start;
                Node PreviousNode = null;
                while (CurrentNode != null && CurrentNode.Data != item)
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
