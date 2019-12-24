using Travelling_SalesMan_Problem;

namespace Lab_8
{
    class LinkedList
    {
        Node start;
        int length;
        public LinkedList()
        {
            this.start = new Node();
        }
        public bool UnderFlow()
        {
            if (this.start.getNext() == null)
                return true;
            else return false;
        }
        public void InsertAtEnd(DeliveryBoy d)
        {
            Node n = new Node(d);
            Node temp = this.start;
            while (temp.getNext() != null)
                temp = temp.getNext();
            temp.setNext(n);
            n.setNext(null);
            this.length++;
        }
        
        public Node DeleteFromStart()
        {
            if (!this.UnderFlow())
            {
                Node temp = this.start.getNext();
                this.start.setNext(temp.getNext());
                this.length--;
                return temp;
            }
            else return null;
        }
        public int getLength()
        {
            return this.length;
        }

    }
}

