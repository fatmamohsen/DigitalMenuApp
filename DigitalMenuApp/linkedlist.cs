using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    class linkedlist
    {
        node start, tail;
        public linkedlist()
        {
            start = tail = null;
        }
        public void add(order data)
        {
            node n1 = new node(data);
            if (start == null)
            {
                start = tail = n1;
            }
            else
            {
                tail.Next = n1;
                tail = n1;
            }
        }
       
    }
}
