using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Hshtbl ht = new Hshtbl(10);
            Loop:
                Console.WriteLine("Enter Integer values only");
                Console.WriteLine("What Would you like to perform:\n1. Insert\n2. Delete\n3. Get Value By Key" +
                    "\n4. Contains\n5. Size\n6. Traverse\n7. Iterator\n8. EXIT");
                int per = Convert.ToInt32(Console.ReadLine());
                switch (per)
                {
                    case 1: //insert
                        Console.WriteLine("Enter Item to Insert:");
                        int val = Convert.ToInt32(Console.ReadLine());
                        ht.insert(val);
                        goto Loop;
                    case 2: // delete the given item
                        Console.WriteLine("Enter Item to Delete:");
                        int val1 = Convert.ToInt32(Console.ReadLine());
                        ht.delete(val1);
                        goto Loop;
                    case 3: // get value by key : prints the element at the given key
                        Console.WriteLine("Enter Key Value:");
                        int k = Convert.ToInt32(Console.ReadLine());
                        ht.getValByKey(k);
                        goto Loop;
                    case 4: //contains: check whether element is present in data structure
                        Console.WriteLine("Enter Value:");
                        int val2 = Convert.ToInt32(Console.ReadLine());
                        ht.contains(val2);
                        goto Loop;
                    case 5: //size of the HashTable
                        ht.size();
                        goto Loop;
                    case 7:
                    case 6: //traverse or print all elements
                        ht.trvrs();
                        goto Loop;
                    case 8: //exit
                        Environment.Exit(0);
                        goto Loop;
                    default:
                        Console.WriteLine("Enter correct Input");
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
