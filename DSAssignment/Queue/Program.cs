using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int index = 0;
                int[] queue = new int[10];
            Loop:
                Console.WriteLine("Enter Integer values only");
                Console.WriteLine("What Would you like to perform:\n1. Enqueue\n2. Dequeue\n3. Peek\n4.Contains\n5. Size\n6. Sort\n" +
                    "7. Reverse\n8. Traverse\n9. Iterator\n10. EXIT");
                int per = Convert.ToInt32(Console.ReadLine());
                switch (per)
                {
                    case 1: //enqueue: insert at the end of queue
                        if (index < 10)
                        {
                            Console.WriteLine("Enter the value for Enqueue:");
                            queue[index] = Convert.ToInt32(Console.ReadLine());
                            index += 1;
                        }
                        else
                        {
                            Console.WriteLine("Queue Overflow");
                        }
                        goto Loop;
                    case 2: //dequeue: removes and prints the first element of queue
                        if (index > 0)
                        {
                            Console.WriteLine("Dequeued:{0}", queue[0]);
                            for(int i = 0; i < index; i++)
                            {
                                queue[i] = queue[i + 1];
                            }
                            index -= 1;
                        }
                        else
                        {
                            Console.WriteLine("Queue Underflow");
                        }
                        goto Loop;
                    case 3: //peek: prints the first element of the queue
                        Console.WriteLine("Peek:{0}", queue[0]);
                        goto Loop;
                    case 4: //contains : check's whether an element is present 
                        Console.WriteLine("Enter the value for Contains:");
                        int con = Convert.ToInt32(Console.ReadLine());
                        bool cons = false;
                        for (int i = 0; i < index; i++)
                        {
                            if (con == queue[i])
                            {
                                cons = true;
                                break;
                            }
                        }
                        Console.WriteLine("Contains {0}:{1}", con, cons);
                        goto Loop;
                    case 5: //size of the queue
                        Console.WriteLine("Size:{0}", index);
                        goto Loop;
                    case 6: //sort's the elements inside
                        int[] a = queue;
                        for (int i = 0; i < index; i++)
                        {
                            if (a[i] > a[i + 1])
                            {
                                int temp = a[i];
                                a[i] = a[i + 1];
                                a[i + 1] = a[i];
                            }
                            for (int j = 0; j < index; j++)
                            {
                                Console.WriteLine(a[j]);
                            }
                        }
                        goto Loop;
                    case 7: //reverses the order of the queue
                        Array.Reverse(queue);
                        Console.WriteLine("Queue is Reversed");
                        goto Loop;
                    case 9:
                    case 8: //traverse or print all elements
                        Console.WriteLine("Traverse:");
                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine(queue[i]);
                        }
                        goto Loop;
                    case 10:    //exit
                        Environment.Exit(0);
                        goto Loop;
                    default:
                        Console.WriteLine("Enter a valid Input.");
                        goto Loop;
                }
            }
            catch (System.FormatException)  //in case there is no input or wrong data type is entered
            {
                Console.WriteLine("No Input/Wrong Input");
                Console.WriteLine("Please Enter Integer Values only.");
            }
            }
    }
}
