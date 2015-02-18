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
            l.printList();
        }
    }
}
