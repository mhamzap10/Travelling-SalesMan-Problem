using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    class Node
    {
        private Node Next;
        private int data;
        public Node(int data, Node next)
        {
            this.data = data;
            this.Next = next;
        }
        public Node()
        {
            this.data = 0;
            this.Next = null;
        }
        public Node(int data)
        {
            this.data = data;
        }
        public Node(Node next)
        {
            this.Next = next;
        }
        public int getData()
        {
            return this.data;
        }
        public Node getNext()
        {
            return this.Next;
        }
        public void setData(int data)
        {
            this.data = data;
        }
        public void setNext(Node next)
        {
            this.Next = next;
        }
    }
}
