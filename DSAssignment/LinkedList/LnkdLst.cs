using System;

namespace LinkedList
{
    public class LnkdLst
    {

        Node head;   // head node marks the starting point of list
        public LnkdLst()
        {
            head = null;
        }

        //1. Insert 
        public void InsrtBeg(int data)
        {
            Node toAdd = new Node(data); // new node is created with req data
            toAdd.next = head;           // this new node is added before the current head
            head = toAdd;
        }
        //2. Insert at Position
        public void InsrtPsn(int data, int pos)
        {
            if (pos == 0)           //pos == 0 means, data is inserted at beginning, hence InsertBeginng is called
            {
                InsrtBeg(data);
            }
            else
            {
                Node toAdd = new Node(data);
                Node prev = head;

                for (int i = 0; i < pos - 1; i++) //we traverse till required position
                {
                    prev = prev.next;
                }
                toAdd.next = prev.next;
                prev.next = toAdd;
            }
        }

        //3. Delete 
        public void DltBeg()
        {
            head = head.next;
            return;
        }

        //4. Delete at Position
        public void DltPsn(int pos)
        {
            if (pos == 0)
                DltBeg();
            else
            {
                Node prev = head;
                for (int i = 0; i < pos - 1; i++) // traverse till required position
                    prev = prev.next;

                prev.next = prev.next.next;
            }
        }


        //5. Size
        public int Size()
        {
            int count = 0;
            Node curr = head;

            while (curr != null)
            {
                count++;
                curr = curr.next;
            }
            return count;
        }



        // 6. Sort
        public void Srt()
        {
            Node ptr = head;
            Node cpt;
            int temp;

            while (ptr != null)
            {
                cpt = ptr.next;
                while (cpt != null)
                {
                    if (ptr.data > cpt.data)
                    {
                        temp = cpt.data;
                        cpt.data = ptr.data;
                        ptr.data = temp;
                    }
                    cpt = cpt.next;
                }
                ptr = ptr.next;
            }

        }

        //7. Reverse
        public void Rvrs()
        {
            Node curr = head;
            Node prev = null;

            while (curr != null)
            {
                Node temp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = temp;
            }

            head = prev;
        }

        
        //8. Traverse 
        public void Traverse()
        {
            Node curr = head;

            Console.WriteLine("----Linked List Data-----");
            while (curr != null)
            {
                Console.WriteLine(curr.data);
                curr = curr.next;
            }
        }

    }
}
