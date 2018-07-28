using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Stack : ICommonOperations
    {
        private int[] m_stackArray = new int[10000];
        private int m_top = -1;
        public int GetTopValue()
        {
            Console.WriteLine();
            return m_stackArray[m_top];
        }
        public void Add(int data)
        {
            m_stackArray[++m_top] = data;
        }
        public void Remove()
        {
            m_top--;
        }
        public void Display()
        {
            int currentPosition = m_top;
            while (currentPosition != -1)
            {
                Console.Write(m_stackArray[currentPosition] + " ");
                currentPosition--;
            }
        }
        public void Sort()
        {
            for(int outerIndex = 0; outerIndex <= m_top; outerIndex++)
            {
                for(int innerIndex = outerIndex; innerIndex <= m_top; innerIndex++)
                {
                    if (m_stackArray[innerIndex] > m_stackArray[outerIndex])
                    {
                        int temp = m_stackArray[outerIndex];
                        m_stackArray[outerIndex] = m_stackArray[innerIndex];
                        m_stackArray[innerIndex] = temp;
                    }
                }
            }

        }
    }
}
