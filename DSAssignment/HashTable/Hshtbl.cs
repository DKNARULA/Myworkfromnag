using System;

namespace HashTable
{
    class Hshtbl
    {
        int[] arr;
        int capacity;

        public Hshtbl(int capacity)
        {
            this.capacity = nxtPrime(capacity);
            arr = new int[this.capacity];
        }

        public int genkey(int element) // function to generate unique key for every element using  modulo
        {
            return (element % capacity);
        }
        //Delete
        public void delete(int item)
        {
            int key = genkey(item);
            if (arr[key] == item)
                arr[key] = 0;
            else
                Console.WriteLine("Element not found");
        }

        //Insert
        public void insert(int item)
        {
            int key = genkey(item);
            arr[key] = item;
        }

        //Contains
        public void contains(int item)
        {
            int key = genkey(item);
            if (arr[key] == item)
                Console.WriteLine("Hash Table Contains {0} ", item);
            else
                Console.WriteLine("Hash Table does NOT contain {0}", item);
        }


        // Value by Key
        public void getValByKey(int k)
        {
            Console.WriteLine(arr[k]);
        }


        //Size
        public int size()
        {
            int count = 0;
            for (int i = 0; i < capacity; i++)
            {
                if (arr[i] > 0)
                    count++;
            }
            return count;
        }

        //Print
        public void trvrs()
        {
            Console.WriteLine("Hash Table:");
            for (int i = 0; i < capacity; i++)
                Console.WriteLine(arr[i] + " ");
        }

        //function to generate next prime number
        private static int nxtPrime(int n)
        {
            if (n % 2 == 0)
                n++;

            for (; !checkPrime(n); n += 2) ;

            return n;
        }

        // Function to check if given number is prime 
        private static bool checkPrime(int n)
        {
            if (n == 2 || n == 3)
                return true;
            if (n == 1 || n == 0)
                return false;
            for (int i = 2; i <= n; i += 2)
                if (n % i == 0)
                    return false;
            return true;
        }
    }
}
