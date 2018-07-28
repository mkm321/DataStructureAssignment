using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Program
    {
        //Function for all linked list operations
        static void LinkListOperation()
        {
            LinkedList linkedList = new LinkedList();
            int choiceLL;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Enter 1 to add at Begining " +
                                    "\n2 to add at given position " +
                                    "\n3 to delete at Begining " +
                                    "\n4 to delete at given position " +
                                    "\n5 to show the linked list " +
                                    "\n6 to Sort the linked list " +
                                    "\n7 to exit");
                choiceLL = int.Parse(Console.ReadLine());
                int data;
                int position;
                switch (choiceLL)
                {
                    case 1:
                        Console.Write("Enter Data to add :- ");
                        data = int.Parse(Console.ReadLine());
                        linkedList.Add(data);
                        Console.WriteLine();
                        Console.WriteLine("Data Inserted");
                        break;
                    case 2:
                        Console.Write("Enter Data to add :- ");
                        data = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("Enter Position :- ");
                        position = int.Parse(Console.ReadLine());
                        linkedList.InsertAtSpecificPosition(data, position);
                        Console.WriteLine();
                        Console.WriteLine("Data Inserted");
                        break;
                    case 3:linkedList.Remove();
                        Console.WriteLine();
                        Console.WriteLine("Data Removed");
                        break;
                    case 4:
                        Console.Write("Enter Position :- ");
                        position = int.Parse(Console.ReadLine());
                        linkedList.RemoveAtSpecificPosition(position);
                        Console.WriteLine();
                        Console.WriteLine("Data Removed");
                        break;
                    case 5:
                        Console.Write("Linked list contains :- ");
                        linkedList.Display();
                        break;
                    case 6:linkedList.Sort();
                        Console.WriteLine();
                        Console.WriteLine("List Sorted");
                        break;
                    case 7:break;
                    default:
                        Console.WriteLine("Invalid Entry");
                        break;
                }
            }
            while (choiceLL!=7);
        }
        //function for all stack operations
        static void StackOperation()
        {
            Stack stack = new Stack();
            int choiceStack;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Enter 1 to add a value in stack " +
                    "\n2 to remove value " +
                    "\n3 to show the stack " +
                    "\n4 to get top value " +
                    "\n5 to sort the stack" +
                    "\n6 to Exit ");
                choiceStack = int.Parse(Console.ReadLine());
                switch (choiceStack)
                {
                    case 1:
                        Console.WriteLine("Enter Elements");
                        int data = int.Parse(Console.ReadLine());
                        stack.Add(data);
                        Console.WriteLine("Data Added");
                        break;
                    case 2: stack.Remove();
                        Console.WriteLine("Data removed");
                        break;
                    case 3:
                        Console.Write("Stack contains :- ");
                        stack.Display();
                        Console.WriteLine();
                        break;
                    case 4:
                        int top = stack.GetTopValue();
                        Console.WriteLine("Top of the stack is :- " + top);
                        Console.WriteLine();
                        break;
                    case 5:
                        stack.Sort();
                        Console.WriteLine("Stack Sorted");
                        break;
                    case 6:
                        break;
                    default: Console.WriteLine("Invalid Entry");
                        break;
                }
            }
            while (choiceStack!=6);
        }
        //function for all queue operations
        static void QueueOperation()
        {
            Queue queue = new Queue();
            int choiceQueue;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Enter 1 to add " +
                                    "\n2 to remove " +
                                    "\n3 to show " +
                                    "\n4 to sort " +
                                    "\n5 to find peek element " +
                                    "\n6 to check queue is full or not " +
                                    "\n7 to check queue is empty or not " +
                                    "\n8 to Exit");
                choiceQueue = int.Parse(Console.ReadLine());
                int data;
                switch (choiceQueue)
                {
                    case 1:
                        Console.Write("Enter Data to add :- ");
                        data = int.Parse(Console.ReadLine());
                        queue.Add(data);
                        Console.WriteLine();
                        Console.WriteLine("Data Inserted");
                        break;
                    case 2:
                        queue.Remove();
                        Console.WriteLine("Data Removed");
                        break;
                    case 3:
                        Console.Write("Displaying Queue :- ");
                        queue.Display();
                        Console.WriteLine();
                        break;
                    case 4:
                        queue.Sort();
                        Console.WriteLine();
                        Console.WriteLine("Queue Sorted");
                        break;
                    case 5:
                        data =queue.Peek();
                        Console.WriteLine("Peek Value is :- "+ data);
                        break;
                    case 6:
                        int response = queue.IsFull();
                        if (response == 1)
                        {
                            Console.WriteLine("Queue is full...");
                        }
                        else
                        {
                            Console.WriteLine("Queue is not full...");
                        }
                        break;
                    case 7:
                        response = queue.IsEmpty();
                        if (response == 1)
                        {
                            Console.WriteLine("Queue is Empty");
                        }
                        else
                        {
                            Console.WriteLine("Queue is not Empty");
                        }
                        break;
                    case 8:
                        break;
                    default:
                        Console.WriteLine("Invalid Entry");
                        break;
                }
            }
            while (choiceQueue != 8);
        }
        static void Main(string[] args)
        {
            int choiceDataStructure;
            do
            {

                Console.WriteLine();
                Console.WriteLine("Enter 1 to Enter into Linked List World" +
                    "\n2 to Enter into Stack World " +
                    "\n3 to Enter into Queue World " +
                    "\n4 to Leave This world ");
                choiceDataStructure = int.Parse(Console.ReadLine());
                switch (choiceDataStructure)
                {
                    case 1:
                        LinkListOperation();
                        Console.WriteLine("Exiting Linked list World...");
                        break;
                    case 2:StackOperation();
                        Console.WriteLine("Exiting Stack World...");
                        break;
                    case 3:
                        QueueOperation();
                        Console.WriteLine("Exiting Queue World...");
                        break;
                    case 4:break;
                    default: Console.WriteLine("Invalid Entry");
                        break;
                }
            }
            while (choiceDataStructure!=4);
            Console.WriteLine("Bye, Thanks For using the Services");
            Console.ReadKey();
        }
    }
}
