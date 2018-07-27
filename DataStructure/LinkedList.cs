using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Node
    {
        public int data;
        public Node Next;
        public Node(int data)
        {
            this.data = data;
            Next = null;
        }
    }
    class LinkedList : ICommonOperations
    {
        Node Head = null;
        public void Add(int data)
        {
            Node NewNode = new Node(data);
            NewNode.Next = Head;
            Head = NewNode; 
        }
        public void InsertAtSpecificPosition(int data,int i)
        {
            Node New_Node = new Node(data);
            if (Head == null)
            {
                Add(data);
            }
            else
            {
                int index = 0;
                Node NewNode = new Node(data);
                Node current = Head;
                while(current!=null && index < (i - 2))
                {
                    current = current.Next;
                    index++;
                }
                if (current == null)
                {
                    Console.WriteLine("Invalid Position");
                }
                NewNode.Next = current.Next;
                current.Next = NewNode;
            }

        }
        public void RemoveAtSpecificPosition(int i)
        {
            if (Head == null)
            {
                Console.WriteLine("Empty");
            }
            else if (Head.Next == null)
            {
                Remove();
            }
            else
            {
                int index = 0;
                Node current = Head;
                while(current!=null && index < (i - 2))
                {
                    current = current.Next;
                    index++;
                }
                if (current == null)
                {
                    Console.WriteLine("Invalid Position");
                }
                else
                {
                    current.Next = current.Next.Next;
                }
            }
        }
        public void Remove()
        {
            if (Head != null)
            {
                Head = Head.Next;
            }
        }
        public void Display()
        {
            Node Temporary = Head;
            while (Temporary != null)
            {
                Console.Write(Temporary.data + " ");
                Temporary = Temporary.Next;
            }
            Console.WriteLine();
        }
        public void Sort()
        {
            Node Temp = Head;
            while (Temp.Next != null)
            {
                Node Temp1 = Temp.Next;
                while (Temp1 != null)
                {
                    if (Temp.data > Temp1.data)
                    {
                        int d = Temp.data;
                        Temp.data = Temp1.data;
                        Temp1.data = d;
                    }
                    Temp1 = Temp1.Next;
                }
                Temp = Temp.Next;
            }
        }
    }
}
