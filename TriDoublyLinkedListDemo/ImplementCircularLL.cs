using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriDoublyLinkedListDemo
{
    internal class ImplementCircularLL
    {
        static void Main(string[] args)
        {
            CircularLL circularLL = new CircularLL();
            CNode Fhead = new CNode();
            Fhead.data = 10;
            circularLL.head = Fhead;
            Fhead.Next = circularLL.head;

            //Add second node
            CNode second=new CNode();
            second.data = 20;
            Fhead.Next = second;
            second.Next = circularLL.head;

            //Add third node
            CNode third = new CNode();
            third.data = 30;
            second.Next = third;
            third.Next = circularLL.head;

            circularLL.PrintList();
            Console.ReadLine();
        }
    }
}
