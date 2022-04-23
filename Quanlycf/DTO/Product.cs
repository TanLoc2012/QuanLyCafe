using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Quanlycf.DTO
{
    public class Product
    {
        public Product()
        {

        }
        private int id;
        public int ID
        {
            get { return this.id; }
            private set { this.id = value; }
        }
        private int name;
        public int Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }
        private int price;
        public int Price
        {
            get { return this.price; }
            private set { this.price = value; }
        }
        public Product(DataRow row)

        {
            this.id = (int)row["id"];

            this.name = (int)row["title"];
            this.price = (int)row["price"];
        }

    }
}
