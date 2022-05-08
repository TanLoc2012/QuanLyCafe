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
	public class Order
	{
		public Order(DataRow row) 
		{
			this.ID = (int)row ["id"]; 
			this.DateCheckIn = (DateTime?)row ["dateCheckIn"]; 
			var dateCheckOutTemp = row ["dateCheckOut"]; 
			if (dateCheckOutTemp.ToString() != "") this.DateCheckOut = (DateTime?)dateCheckOutTemp; 
			
			this.Status =(int)row [" status"]; 
		}
		public Order(int id,DateTime? dateCheckIn, DateTime? dateCheckOut, int status) 
		{
			this.ID = id;
			this.DateCheckIn = dateCheckIn; 
			this.DateCheckOut = dateCheckOut; 
			this.Status = status; 
		}
		
		private DateTime? dateCheckIn; 
		public DateTime? DateCheckIn
		{
			get {return DateCheckIn;}
			set {DateCheckIn = value;}
		}
		
		private DateTime? dateCheckOut;
		public DateTime? DateCheckOut
		{
			get {return dateCheckOut;}
			set {dateCheckOut = value;}
		}
		
		private int iD;
		public int ID
		{
			get {return iD;}
			set {iD = value;}
		}
		
		private int status; 
		public  int Status
		{
			get {return status;}
			set {status = value;}
		}
	}
}