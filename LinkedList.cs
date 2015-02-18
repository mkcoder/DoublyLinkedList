using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doubly_Linked_List
{
    public class LinkedList<T>
    {
        private LinkedListNode<T> head;
        private LinkedListNode<T> tail;

        public LinkedList()
        {
            tail = head = null;
        }

        public void Add(T data)
        {
            LinkedListNode<T> node = new LinkedListNode<T>() {Data = data};
            Add(node);
        }

        private void Add(LinkedListNode<T> node)
        {
            if (tail != null )
            {
                node.Prev = tail;
            }

            if (head != null)
            {
                tail.Next = node;
            }
            else
            {
                head = node;
            }

            tail = node;
        }

        // non-recursive solution
        public void AddNth(T data, int nth)
        {
            int count = 0;
            var temp = head;
            while (count++ != (nth-1))
                temp = temp.Next;

            var node = new LinkedListNode<T>()
                            {
                                Data = data, 
                                Prev = temp.Prev,
                                Next = temp
                            };
            temp.Prev.Next = node;
            temp.Prev = node;
        }

        public T Delete()
        {
            T retr;
            if (head != null)
            {
                retr = head.Data;
                head = head.Next;

            }
            else
            {
                retr = head.Data;
                head = null;
                tail = null;
            }

            return retr;
        }

        public T DeleteFromTail()
        {
            T retr;
            if (tail.Prev != null)
            {
                retr = tail.Data;
                LinkedListNode<T> temp = tail.Prev;
                tail = temp;
                temp.Next = null;
            }
            else
            {
                retr = head.Data;                
                head = null;
                tail = null;
            }
            
            return retr;
        }

        public void printList()
        {
            LinkedListNode<T> tempListNode = head;
            Console.Write("{");
            while (tempListNode != null)
            {
                if (tempListNode.Next != null)
                {
                    Console.Write("{0},", tempListNode.Data);
                }
                else
                {
                    Console.Write("{0}", tempListNode.Data);
                }
                tempListNode = tempListNode.Next;
            }
            Console.WriteLine("}");
        }
    }
}
