namespace LinkedList
{
    public class Node
    {
        public int data;
        public Node next; //contains reference to next node

        //constructor to initialise Node object
        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }
}
