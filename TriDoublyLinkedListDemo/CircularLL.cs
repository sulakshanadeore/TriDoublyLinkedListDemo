using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriDoublyLinkedListDemo
{
    class CNode
    {
        public int data;
        public CNode Next;
    }
    internal class CircularLL
    {
        public CNode head;
        public CircularLL()
        {
            head = null;
        }


        public void PrintList() 
        {
            CNode temp = new CNode();
            temp=this.head;
            if (temp != null)
            {
                while (temp != null)
                {
                    Console.WriteLine(temp.data + " ");
                    temp = temp.Next;
                    if (temp == this.head)  
                        break;     

                }
                Console.WriteLine();


            }
            else
            {
                Console.WriteLine("List is empty");
            }
        
        }
    }
}
