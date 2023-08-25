using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int index = 0;
                int[] stack = new int[10];
            Loop:
                Console.WriteLine("Enter Integer values only");
                Console.WriteLine("What Would you like to perform:\n1. Push\n2. Pop\n3. Peek\n4.Contains\n5. Size\n6. Center\n7. Sort\n8. Reverse\n" +
                    "9. Traverse\n10. Iterator\n11. EXIT");
                int per = Convert.ToInt32(Console.ReadLine());
                switch (per)
                {
                    case 1: //  push: insert element at the top of stack
                        if (index < 10)
                        {
                            Console.WriteLine("Enter the value to be pushed:");
                            stack[index] = Convert.ToInt32(Console.ReadLine());
                            index += 1;
                        }
                        else
                        {
                            Console.WriteLine("Stack Overflow");
                        }
                        goto Loop;
                    case 2: //  pop : removes and prints the element from the top of the stack
                        if (index > 0)
                        {
                            Console.WriteLine("Poped:{0}", stack[index - 1]);
                            stack[index - 1] = 0;
                            index -= 1;
                        }
                        else
                        {
                            Console.WriteLine("Stack Underflow");
                        }
                        goto Loop;
                    case 3: //  peek: prints the element from the top of the stack
                        Console.WriteLine("Peek:{0}",stack[index-1]);
                        goto Loop;
                    case 4: //  contains : check's whether an element is present 
                        Console.WriteLine("Enter the value for Contains:");
                        int con = Convert.ToInt32(Console.ReadLine());
                        bool cons = false;
                        for(int i = 0; i < index; i++)
                        {
                            if (con == stack[i])
                            {
                                cons = true;
                                break;
                            }
                        }
                        Console.WriteLine("Contains {0}:{1}",con,cons);
                        goto Loop;
                    case 5: //  size of the stack
                        Console.WriteLine("Size:{0}",index);
                        goto Loop;
                    case 7: //  sort's the elements inside
                        int[] a = stack;
                        for(int i = 0;i<index;i++)
                        {
                            if(a[i]>a[i+1])
                            {
                                int temp = a[i];
                                a[i] = a[i + 1];
                                a[i + 1] = a[i];
                            }
                            for(int j = 0; j < index; j++)
                            {
                                Console.WriteLine(a[j]);
                            }
                        }
                        goto Loop;
                    case 8:    //   reverses the order of the stack
                        Array.Reverse(stack);
                        Console.WriteLine("Stack is Reversed");
                        goto Loop;
                    case 10:
                    case 9: //  traverse or print all the elements
                        Console.WriteLine("Traverse:");
                        for(int i=0;i<index;i++)
                        {
                            Console.WriteLine(stack[i]);
                        }
                        goto Loop;
                    case 11:    //  exit
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
                Console.WriteLine("Please Enter Integer Values Only.");
            }
        }
    }
}
