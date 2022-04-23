using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Quanlycf.DTO
{
    public class OrderDetail
    {
        private OrderDetail()
        {

        }
        private int id;
        public int ID
        {
            get { return this.id; }
            private set { this.id = value; }
        }
        private int id_order;
        public int ID_Order
        {
            get { return this.id_order; }
            set { this.id_order = value; }
        }
        private List<int> id_products;
        public List<int> ID_Products
        {
            get { return this.id_products; }
            set { this.id_products = value; }
        }




    }
}
