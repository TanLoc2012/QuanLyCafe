using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Quanlycf.DTO
{
    public class Order
    {
        public Order(int id, int id_nv, int total_money, bool status, DateTime ngay_ban)
        {
            this.id = id;
            this.id_nv = id_nv;
            this.total_money = total_money;
            this.status = status;
            this.ngay_ban = ngay_ban;
        }
        public Order(DataRow row)

        {
            this.id = (int)row["id"];
            this.id_nv = (int)row["id_nv"];
            this.total_money = (int)row["total_money"];
            this.status = (bool)row["status"];
            this.ngay_ban = (DateTime)row["ngay_ban"];
        }
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private int id_nv;
        public int ID_NV
        {
            get { return id_nv; }
            set { id_nv = value; }
        }

        private int total_money;
        public int TOTAL_MONEY
        {
            get { return total_money; }
            set { total_money = value; }
        }
        private bool status;
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
        private DateTime ngay_ban;
        public DateTime NgayBan
        {
            get { return ngay_ban; }
            set { ngay_ban = value; }
        }
    }
}
