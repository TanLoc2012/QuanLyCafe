using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Quanlycf
{
	public class OrderDetail
	{
		public OrderDetail(int id, int billID, int foodID, int count) 
		{
			this.ID = id; 
			this.BillID = billID; 
			this.FoodID = foodID; 
			this.Count = count; 
		}
		public OrderDetail(DataRow row) 
		{
			this.ID = (int)row ["id"]; 
			this.BillID = (int)row ["idbill"]; 
			this.FoodID = (int)row ["idfood"]; 
			this.Count = (int)row ["count"]; 
		}
		private int count; 
		public int Count
		{
			get {return count;}
			set {count = value;} 
		}
		
		private int foodID; 
		public int FoodID
		{
			get {return foodID;}
			set {foodID = value;} 
		}
		
		private int billID; 
		public int BillID
		{
			get {return billID;}
			set {billID = value;} 
		}
		
		private int iD; 
		public int ID
		{
			get {return iD;}
			set {iD = value;} 
		}
		
	}
}