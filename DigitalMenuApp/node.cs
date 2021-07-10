using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    class node
    {
        node next;
        order data;

        public node Next
        {
            get
            {
                return next;
            }

            set
            {
                next = value;
            }
        }

        public order Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }
        public node(order data)
        {
            this.data = data;
            next = null;
        }
    }

}
