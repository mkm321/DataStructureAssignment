using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Stack : ICommonOperations
    {
        int[] stackArray=new int[10000];
        int top = -1;
        public int GetTopValue()
        {
            Console.WriteLine();
            return stackArray[top];
        }
        public void Add(int data)
        {
            stackArray[++top] = data;
        }
        public void Remove()
        {
            top--;
        }
        public void Display()
        {
            int current = top;
            while (current != -1)
            {
                Console.Write(stackArray[current] + " ");
                current--;
            }
        }
        public void Sort()
        {
            for(int i = 0; i <= top; i++)
            {
                for(int j = i; j <= top; j++)
                {
                    if (stackArray[j] > stackArray[i])
                    {
                        int temp = stackArray[i];
                        stackArray[i] = stackArray[j];
                        stackArray[j] = temp;
                    }
                }
            }

        }
    }
}
