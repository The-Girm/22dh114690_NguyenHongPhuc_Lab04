using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22dh114690_NguyenHongPhuc_Lab04
{
    internal class MyList
    {
        private IntNode first;
        private IntNode last;
        public IntNode First
        {
            get { return first; }
            set { first = value; }
        }
        public IntNode Last
        {
            get { return last; }
            set { last = value; }
        }
        public int Count { get; }
        public MyList()
        {
            first = null;
            last = null;
        }
        public bool IsEmpty()
        {
            return first == null ;
            
        }
        public void AddFirst(IntNode newNode)
        {
            if (IsEmpty())
                first = last = newNode;
            else

            {
                newNode.Next = first;
                first = newNode;
            }
        }
        public void AddLast(IntNode newNode)
        {
            if (IsEmpty())
                first = last = newNode;
            else

            {
                last.Next=newNode;
                last = newNode;
            }
        }
       public IntNode GetMin()
        {
            IntNode min = first;
            while (first.Next != null)
            {
                if (first.Next.Data < min.Data)
                    min = first.Next;
                first = first.Next;
            }
            return min;
        }
        public IntNode GetMax()
        {
            IntNode max = first;
            while (first.Next != null)
            {
                if (first.Next.Data > max.Data)
                    max = first.Next;
                first = first.Next;
            }
            return max;
        }
        public IntNode SearchX(int x)
        {
            
            while (first!=null)
            {
                if (first.Data == x)
                {
                    return first;
                }
                first = first.Next;
            }
            return null;
        }
        public MyList GetEvenList(MyList List)
        {
            MyList list = new MyList();
            while(List.first!=null)
            {
                if (List.first.Data % 2 == 0)
                    list.AddLast(List.first);
                List.first = List.first.Next;
            }
            return list;
        }
        public MyList GetOddList(MyList List)
        {
            MyList list = new MyList();
            while (List.first != null)
            {
                if (List.first.Data % 2 != 0)
                    list.AddLast(List.first);
                List.first = List.first.Next;
            }
            return list;
        }
        public void ShowList()
        {
            IntNode p = first;
           
            while (p != null)
            {
                Console.Write("{0} -> ", p.Data);
                p = p.Next;
            }
            Console.WriteLine("null");
        }
    }
}


