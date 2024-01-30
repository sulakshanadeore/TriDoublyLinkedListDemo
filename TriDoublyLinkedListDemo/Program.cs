using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriDoublyLinkedListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DoublyLL doublyLL = new DoublyLL();

            //create a first node
            Node first = new Node();
            first.data = 10;
            first.Next = null;
            first.Prev = null;
            doublyLL.head = first;

            //add the second node
            Node second = new Node();
            second.data = 20;
            second.Next = null;
            second.Prev = first;
            first.Next = second;

            //add the third node
            Node third = new Node();
            third.data = 30;
            third.Next = null;
            third.Prev = second;
            second.Next = third;

            doublyLL.PrintList();
            Console.ReadLine();

        }

    }
}
