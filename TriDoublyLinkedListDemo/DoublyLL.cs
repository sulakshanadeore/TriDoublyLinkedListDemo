using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriDoublyLinkedListDemo
{
    class Node {
        public int data;
        public Node Next;
        public Node Prev;
    
    }
    internal class DoublyLL
    {
       public Node head;
      public  Node tail;
        int size;

        public DoublyLL()
        {
            head = null;
        }

        public void PrintList()
        {

            Node temp = new Node();
            temp = this.head;
            if (temp!=null)
            {
                Console.WriteLine("Printing the list");
                while (temp != null)
                {
                    Console.WriteLine(temp.data + "  ");
                    temp = temp.Next;
                }
                Console.WriteLine(  );

            }
            else
            {
                Console.WriteLine("The list is empty");
            }
        }


    }
}
