using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doubly_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> l = new LinkedList<int>();
            l.Add(1);
            l.Add(2);
            l.Add(3);            
            l.Add(5);
            l.AddNth(4,4);
            l.printList();
            Console.WriteLine(l.Delete());
            l.printList();
            Console.WriteLine(l.DeleteFromTail());
            l.printList();
            Console.WriteLine(l.Delete());
            l.printList();
            Console.WriteLine(l.DeleteFromTail());
            l.printList();
            Console.WriteLine(l.DeleteFromTail());
            l.printList();

            /* 
                program output: 
                {1,2,3,4,5}
                1
                {2,3,4,5}
                5
                {2,3,4}
                2
                {3,4}
                4
                {3}
                3
                {}
                Press any key to continue . . .
             */
        }
    }
}
