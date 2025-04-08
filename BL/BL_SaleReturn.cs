using PharmacyMgt.BL.custom;
using PharmacyMgt.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyMgt.BL
{
    public class BL_SaleReturn
    {
        public int SaleReturnId { set; get; }
        public int MedicineId { get; set; }
        public string InvoiceNo { set; get; }
        public int ReturnQty { set; get; }
        public int SalePrice { set; get; }
        public DateTime SaleReturnDate { set; get; }


        public void saleRetInsert()
        {
            SqlParameter[] s = new SqlParameter[6];
            s[0] = new SqlParameter("@ActionType", ActionType.Insert);
            s[1] = new SqlParameter("@MedicineId", MedicineId);
            s[2] = new SqlParameter("@InvoiceNo", InvoiceNo);
            s[3] = new SqlParameter("@ReturnQty", ReturnQty);
            s[4] = new SqlParameter("@SalePrice", SalePrice);
            s[5] = new SqlParameter("@SaleReturnDate", SaleReturnDate);
            db.sp_Query("sp_SaleReturn", s);
        }

        public static DataTable select()
        {
            SqlParameter[] s = new SqlParameter[1];
            s[0] = new SqlParameter("@ActionType", ActionType.Select);
            return db.sp_Table("sp_SaleReturn", s);
        }


        public static DataTable saleretrn(string InvoiceNo)
        {
            SqlParameter[] s = new SqlParameter[2];
            s[0] = new SqlParameter("@ActionType", ActionType.Select);
            s[1] = new SqlParameter("@InvoiceNo",InvoiceNo);
            return db.sp_Table("sp_ReturnSale", s);
        }
    }
}
