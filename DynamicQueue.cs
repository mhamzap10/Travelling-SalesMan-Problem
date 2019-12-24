using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travelling_SalesMan_Problem;

namespace Lab_8
{
    class DynamicQueue
    {
        LinkedList Queu;
        public DynamicQueue()
        {
            Queu = new LinkedList();
        }
        public void Enque(DeliveryBoy d)
        {
            this.Queu.InsertAtEnd(d);
        }
        public bool UnderFlow()
        {
            return this.Queu.UnderFlow();
        }
        public DeliveryBoy Deque()
        {
            return this.Queu.DeleteFromStart().getData();
        }
        public int getLength()
        {
            return this.Queu.getLength();
        }

    }
}
