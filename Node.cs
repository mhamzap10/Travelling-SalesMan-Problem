using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travelling_SalesMan_Problem;

namespace Lab_8
{
    class Node
    {
        private Node Next;
        private DeliveryBoy data;
        public Node(DeliveryBoy data, Node next)
        {
            this.data = data;
            this.Next = next;
        }
        public Node()
        {
            this.data = null;
            this.Next = null;
        }
        public Node(DeliveryBoy data)
        {
            this.data = data;
        }
        public Node(Node next)
        {
            this.Next = next;
        }
        public DeliveryBoy getData()
        {
            return this.data;
        }
        public Node getNext()
        {
            return this.Next;
        }
        public void setData(DeliveryBoy data)
        {
            this.data = data;
        }
        public void setNext(Node next)
        {
            this.Next = next;
        }
    }
}
