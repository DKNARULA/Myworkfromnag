using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                LnkdLst ll = new LnkdLst();
            Loop:
                Console.WriteLine("Enter Integer values only");
                Console.WriteLine("What Would you like to perform:\n1. Insert At Beginning\n2. Insert At Position\n3. Delete\n4. Delete At Position" +
                    "\n5. Size\n6. Sort\n7. Reverse\n8. Traverse\n9. Iterator\n10. EXIT");
                int per = Convert.ToInt32(Console.ReadLine());
                switch (per)
                {
                    case 1: //insert
                        Console.WriteLine("Enter value to Insert at Beginning:");
                        int beg = Convert.ToInt32(Console.ReadLine());
                        ll.InsrtBeg(beg);
                        goto Loop;
                    case 2: //inserts value at the given position
                        Console.WriteLine("Enter value to Insert at Position:");
                        int val = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter position value:");
                        int pos = Convert.ToInt32(Console.ReadLine());
                        ll.InsrtPsn(val, pos);
                        goto Loop;
                    case 3: // delete the element from the beginning
                        ll.DltBeg();
                        goto Loop;
                    case 4: //delete's the element at the given position
                        Console.WriteLine("Enter Position:");
                        int posdel = Convert.ToInt32(Console.ReadLine());
                        ll.DltPsn(posdel);
                        goto Loop;
                    case 5: //size : prints the size of the data structure
                        Console.WriteLine("The Size of the Linked List is:",ll.Size());
                        goto Loop;
                    case 6: //sorts the elements inside the data structure
                        ll.Srt();
                        goto Loop;
                    case 7: //reverses the order of elements
                        ll.Rvrs();
                        goto Loop;
                    case 9:
                    case 8: //traverse or print all elements
                        ll.Traverse();
                        goto Loop;
                    case 10: //exit
                        Environment.Exit(0);
                        goto Loop;
                    default:
                        Console.WriteLine("Enter the correct value:");
                        goto Loop;
                }
            }
            catch(System.FormatException)   //in case there is no input or wrong data type is entered
            {
                Console.WriteLine("No Input/Wrong Input");
            }
        }
    }
}
