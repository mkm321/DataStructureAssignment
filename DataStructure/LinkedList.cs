using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    //This class is creating a Node.
    class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }
    class LinkedList : ICommonOperations
    {
    //intializing head of the linked list with null
        private Node m_head = null;
        public void Add(int data)
        {
            Node newNode = new Node(data);
            newNode.next = m_head;
            m_head = newNode; 
        }
        //Insertion at given position.
        public void InsertAtSpecificPosition(int data,int position)
        {
            Node newNode = new Node(data);
            if (m_head == null)
            {
                Add(data);
            }
            else
            {
                int index = 0;
                Node current = m_head;
                while(current!=null && index < (position - 2))
                {
                    current = current.next;
                    index++;
                }
                if (current == null)
                {
                    Console.WriteLine("Invalid Position");
                }
                newNode.next = current.next;
                current.next = newNode;
            }

        }
        //Removing at given position
        public void RemoveAtSpecificPosition(int position)
        {
            if (m_head == null)
            {
                Console.WriteLine("Empty");
            }
            else if (m_head.next == null)
            {
                Remove();
            }
            else
            {
                int index = 0;
                Node current = m_head;
                while(current!=null && index < (position - 2))
                {
                    current = current.next;
                    index++;
                }
                if (current == null)
                {
                    Console.WriteLine("Invalid Position");
                }
                else
                {
                    current.next = current.next.next;
                }
            }
        }
        public void Remove()
        {
            if (m_head != null)
            {
                m_head = m_head.next;
            }
        }
        public void Display()
        {
            Node temporary = m_head;
            while (temporary != null)
            {
                Console.Write(temporary.data + " ");
                temporary = temporary.next;
            }
            Console.WriteLine();
        }
        public void Sort()
        {
            Node tempHead = m_head;
            while (tempHead.next != null)
            {
                Node tempHeadNext = tempHead.next;
                while (tempHeadNext != null)
                {
                    if (tempHead.data > tempHeadNext.data)
                    {
                        int data = tempHead.data;
                        tempHead.data = tempHeadNext.data;
                        tempHeadNext.data = data;
                    }
                    tempHeadNext = tempHeadNext.next;
                }
                tempHead = tempHead.next;
            }
        }
    }
}
