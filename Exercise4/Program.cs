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
       
        public void pop()
        {
            bool empty()
            {
                if (top == -1)
                    return (true);
                else
                    return (false);

                Console.WriteLine("\n.Stack Empty");
            }
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
                    Console.WriteLine(tmp.info);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Stacks s = new Stacks();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("\n***Stack menu\n***");
                Console.WriteLine("1. Pop ");
                Console.WriteLine("2. Push");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Exit");
                Console.WriteLine("\nEnter your choice: ");
                string sInput = Console.ReadLine();
                char ch = Convert.ToChar(sInput == "" ? "0" : sInput);
                switch (ch)
                {
                    case '1':
                        if (s.empty())
                        {
                            Console.WriteLine("\nStack Empty");
                            break;
                        }
                        s.pop();
                        break;
                    case '2':
                        Console.WriteLine("\nEnter a number: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        s.push(num);
                        break;
                    case '3':
                        s.display();
                        break
                }
            }
        }





    }
}
