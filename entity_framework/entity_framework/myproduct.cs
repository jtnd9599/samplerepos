using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity_framework
{
   public class myproduct
    {
        public int myproductID
        {
            
            set;
        }
        public string prodName
        {
            get;
            set;
        }

        public float prodPrice
        {
            get;
            set;
        }

    }
}
