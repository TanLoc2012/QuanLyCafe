using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; 
namespace Quanlycf
{
    public class Product
    {
        public Product(int id, string name, int categoryID, float price)
        {
            this.ID = id;
            this.Name = name;
            this.CategoryID = categoryID;
            this.Price = price;
            this.Deleted = 0;
            this.DescriptionP = "Test";
            this.Discount = 0; 
        }

        public Product(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["title"].ToString();
            this.CategoryID = (int)row["category_id"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
            this.Deleted = 0;
            this.DescriptionP = "Test";
            this.Discount = 0;
        }

        private float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        private int categoryID;

        public int CategoryID
        {
            get { return categoryID; }
            set { categoryID = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private string thumbnail;
        public string Thumbnail { get => thumbnail; set => thumbnail = value; }
        public string DescriptionP { get => descriptionP; set => descriptionP = value; }
        public int Deleted { get => deleted; set => deleted = value; }
        public int Discount { get => discount; set => discount = value; }

        private string descriptionP;
        private int deleted;
        private int discount; 




    }
}
