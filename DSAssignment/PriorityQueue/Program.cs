using System;
using System.Collections.Generic;
using System.Linq;

namespace PriorityQueue
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Dictionary<int, int> PQ = new Dictionary<int, int>();
                Program pr = new Program();
            Loop:
                Console.WriteLine("Enter Integer values only");
                Console.WriteLine("What Would you like to perform:\n1. Enqueue\n2. Dequeue\n3. Peek" +
                    "\n4.Contains\n5. Size\n6. Traverse\n7. Iterator\n8. EXIT");
                int per = Convert.ToInt32(Console.ReadLine());
                switch (per)
                {
                    case 1: //enqueue: insert
                        Console.WriteLine("Enter the Priority:");
                        int p = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Value:");
                        int val = Convert.ToInt32(Console.ReadLine());
                        PQ.Add(p, val);
                        Console.WriteLine("Item Added");
                        goto Loop;
                    case 2: //dequeue: removes and prints the element with highest priority
                        int minkey = PQ.Keys.Min();
                        PQ.TryGetValue(minkey, out int v);
                        Console.WriteLine("Key:{0}   Value:{1}", minkey, v);
                        PQ.Remove(minkey);
                        Console.WriteLine("Item Removed");
                        goto Loop;
                    case 3: //peek:prints the element with the highest priority
                        int minkey1 = PQ.Keys.Min();
                        PQ.TryGetValue(minkey1, out int v1);
                        Console.WriteLine("Key:{0}   Value:{1}", minkey1, v1);
                        goto Loop;
                    case 4: //contains : check's whether an element is present 
                        Console.WriteLine("Enter value to be checked");
                        int val1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(PQ.ContainsValue(val1));
                        goto Loop;
                    case 5: //size of the stack
                        Console.WriteLine(PQ.Count);
                        goto Loop;
                    case 7:
                    case 6: //  traverse or print all elements
                        foreach (KeyValuePair<int, int> item in PQ)
                        {
                            Console.WriteLine("Key:{0}  Value:{1}", item.Key, item.Value);
                        }
                        goto Loop;
                    case 8: //  exit
                        Environment.Exit(0);
                        goto Loop;
                    default:
                        Console.WriteLine("Enter the correct value");
                        goto Loop;
                }
            }
            catch (System.FormatException)  //in case there is no input or wrong data type is entered
            {
                Console.WriteLine("No Input/Wrong Input");
            }
        }
    }
}
