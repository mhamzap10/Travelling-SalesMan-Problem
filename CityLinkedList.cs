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
        public void InsertAtBegin(int d)
        {
            Node n = new Node(d);
            if (this.UnderFlow())
            {
                this.start.setNext(n);
            }
            else
            {
                n.setNext(this.start.getNext());
                this.start.setNext(n);
            }
            this.length++;
        }
        public Node SearchNode(int d)
        {
            if (!this.UnderFlow())
            {
                Node temp = this.start;
                while (temp.getNext() != null && temp.getData() != d)
                {
                    temp = temp.getNext();
                }
                if (temp.getNext() == null)
                    return null;
                else
                    return temp;
            }
            else return null;
        }
        public void InsertAfter(int d, int val)
        {
            Node n = new Node(val);
            Node sNode = this.SearchNode(d);
            if (sNode != null)
            {
                n.setNext(sNode.getNext());
                sNode.setNext(n);
                this.length++;
            }
            else
                System.Console.WriteLine("Value not Found!");
        }
        public void InsertAtEnd(int d)
        {
            Node n = new Node(d);
            Node temp = this.start;
            while (temp.getNext() != null)
                temp = temp.getNext();
            temp.setNext(n);
            n.setNext(null);
            this.length++;
        }
        public Node SearchByIndex(int index)
        {
            if (index > this.length)
            {
                throw new System.ArgumentException("Illegal Arguement Exception: Index Out of Range");
            }
            else
            {
                Node temp = this.start; //Start has 0 Index;
                for (int i = 1; i<= index; i++)
                    temp = temp.getNext();
                return temp;
            }
        }
        public void InsertAt(int index, int data)
        {
            Node SNode = this.SearchByIndex(index);
            this.InsertBefore(SNode.getData(), data);
        }
        public Node RemoveAt(int index)
        {
            Node SNode = this.SearchByIndex(index);
            return this.DeleteNode(SNode.getData());
        }
        public int get(int n)
        {
            Node temp = this.SearchByIndex(n);
            return temp.getData();
        }
        public void InsertBefore(int d, int val)
        {
            Node n = new Node(val);
            Node sNode = this.start;
            while (sNode.getNext() != null && sNode.getNext().getData() != d)
            {
                sNode = sNode.getNext();
            }
            if (sNode != null)
            {
                n.setNext(sNode.getNext());
                sNode.setNext(n);
                this.length++;
            }
            else System.Console.WriteLine("Value Not found!");
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
        public Node DeleteFromEnd()
        {
            if (!this.UnderFlow())
            {
                Node temp = this.start;
                while (temp.getNext().getNext() != null)
                {
                    temp = temp.getNext();
                }
                Node s = temp.getNext();
                temp.setNext(null);
                this.length--;
                return s;
            }
            else return null;
        }
        public Node DeleteNode(int d)
        {
            Node sNode = this.start;
            while (sNode.getNext() != null && sNode.getNext().getData() != d)
            {
                sNode = sNode.getNext();
            }
            if (sNode != null)
            {
                Node temp = sNode.getNext();
                sNode.setNext(temp.getNext());
                this.length--;
                return temp;
            }
            else return null;
        }
        public void Display()
        {
            Node temp = this.start;
            while(temp.getNext() != null)
            {
                temp = temp.getNext();
                System.Console.Write(temp.getData()+" ");
            }
            System.Console.WriteLine();
        }
        public int getLength()
        {
            return this.length;
        }

    }
}

