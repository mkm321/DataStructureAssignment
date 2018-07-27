using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Queue : ICommonOperations
    {
        static int max = 10;
        int first = 0;
        int last = 0;
        int[] queueStack = new int[max];
        public void Add(int data)
        {
            if (last == 10)
            {
                Console.WriteLine("Sorry, Queue is full! ");
            }
            else
            {
                queueStack[last]=data;
                last++;
            }
        }
        public void Remove()
        {
            if (first == last)
            {
                Console.WriteLine("Queue is already Empty!");
            }
            else
            {
                queueStack[first] = 0;
                first++;
            }
        }
        public void Display()
        {
            int temp = first;
            for(int i = temp; i <= last-1; i++)
            {
                Console.Write(queueStack[i] + " ");
            }
        }
        public void Sort()
        {
            for(int i = first; i <= last; i++)
            {
                for(int j = first; j <= last; j++)
                {
                    if (queueStack[j] < queueStack[j+1])
                    {
                        int temp = queueStack[j];
                        queueStack[j] = queueStack[j+1];
                        queueStack[j+1] = temp;
                    }
                }
            }
        }
        public int peek()
        {
            return queueStack[first];
        }
        public int isFull()
        {
            if (last == max)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int isEmpty()
        {
            if (first==last)
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
