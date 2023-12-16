using System;

namespace Linked_List_Homework
{
    public class LinkedList
    {
        public Node First { get; set; }

        public void Print()
        {
            Node move = First;
            while (move != null)
            {
                Console.Write(move.Data+"\t");
                move = move.Next;
            }
            Console.WriteLine();
        }

        // methods
        public void Add(int val)
        {
            // TODO: add item to the end of the list
            // consider when the list is empty

            // create a new node with the given data
            Node n = new Node(val);
            if (First == null)
            {
                First = n;
                return;
            }
            
            {
                Node temp = First;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = n;
            }
        }
        public void RemoveKey(int key)
        {
            // TODO: search for the key and remove it from the list
            // consider when the key does not exist and when the list is empty
            if (First == null)
                return;
            if (First.Data==key)
            {
             First=First.Next;
                return;
            }
            Node temp = First;
            while (temp.Next != null && temp.Next.Data != key)
            {
                temp = temp.Next;
            }
            if(temp.Next!=null)
            {
                temp.Next = temp.Next.Next;
            }
        }
        public void Merge(LinkedList other_list)
        {
            // TODO: merge this list with the other list
             if(First==null)
            {
                First = other_list.First;
                return;
            }
            Node temp = First;
            while (temp.Next != null)
            { 
            temp=temp.Next;
            }
            temp.Next = other_list.First;
        }
        }
        public void Reverse()
        {
            // TODO: revers the nodes of this list
            // initialize three pointers: prev, curr, and next
             Node prev = null;
            Node current = First;
            Node next = null;
            while (current != null) 
            {
            next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            First = prev;
        }
    }
}
