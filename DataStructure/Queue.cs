using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Queue : ICommonOperations
    {
        private static int m_max = 10;
        private int m_first = 0;
        private int m_last = 0;
        private int[] m_queueArray = new int[m_max];
        public void Add(int data)
        {
            if (m_last == 10)
            {
                Console.WriteLine("Sorry, Queue is full! ");
            }
            else
            {
                m_queueArray[m_last]=data;
                m_last++;
            }
        }
        public void Remove()
        {
            if (m_first == m_last)
            {
                Console.WriteLine("Queue is already Empty!");
            }
            else
            {
                m_queueArray[m_first] = 0;
                m_first++;
            }
        }
        public void Display()
        {
            int temp = m_first;
            for(int index = temp; index <= m_last - 1; index++)
            {
                Console.Write(m_queueArray[index] + " ");
            }
        }
        public void Sort()
        {
            for(int outerIndex = m_first; outerIndex <= m_last; outerIndex++)
            {
                for(int innerIndex = m_first; innerIndex <= m_last; innerIndex++)
                {
                    if (m_queueArray[innerIndex] < m_queueArray[innerIndex + 1])
                    {
                        int temp = m_queueArray[innerIndex];
                        m_queueArray[innerIndex] = m_queueArray[innerIndex + 1];
                        m_queueArray[innerIndex + 1] = temp;
                    }
                }
            }
        }
        public int Peek()
        {
            return m_queueArray[m_first];
        }
        public int IsFull()
        {
            if (m_last == m_max)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int IsEmpty()
        {
            if (m_first == m_last)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

    }
}
