using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    //membuat class program
    class Program
    {
        //menggunakan array
        int[] arr = new int[87];
        public int info;
        public Array next;
        //number of elements in the array
        int n;
        //get the top number of elements to store in the array
        int top;

    }

    class Stacks
    {
        int top = -1;

        public Stacks()
        {
            int top = -1;
        }
        bool empty()
        {
            if (top == -1)
                return (true);
            else
                return (false);

            Console.WriteLine("\n.Stack Empty");
        }
        public void pop()
        {

        }
        public void push(int element)
        {
            Array arri;
            arri = new Array(element, null);

            arri.next = top;
            top = arri;
            Console.WriteLine("\n" + element + "pushed.");
        }
        public void display()
        {
            Array tmp;
            if (empty())
                Console.WriteLine("\nStack Empty");
            else
            {
                for (tmp = top; tmp != null; tmp = tmp.next)
                {

                }
            }
        }





    }
}
