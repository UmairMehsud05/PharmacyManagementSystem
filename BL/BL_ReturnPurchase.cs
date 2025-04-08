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
    public class BL_ReturnPurchase
    {
        public int PReturnID { get; set; }
        public int MedicineId { get; set; }
        public string InvoiceNo { get; set; }
        public int QTY { get; set; }
        public int PPrice { get; set; }
        public DateTime RDate { get; set; }
        
        
        public void insert()
        {
            SqlParameter[] p = new SqlParameter[6];
            p[0] = new SqlParameter("@ActionType", ActionType.Insert);
            p[1] = new SqlParameter("@MedicineId", MedicineId);
            p[2] = new SqlParameter("@InvoiceNo", InvoiceNo);
            p[3] = new SqlParameter("@QTY", QTY);
            p[4] = new SqlParameter("@PPrice", PPrice);
            p[5] = new SqlParameter("@RDate", RDate);
            db.sp_Query("sp_PurchaseReturn", p);
        }

        public static DataTable ReturnPur(int InvoiceNo)
        {
            SqlParameter[] s = new SqlParameter[2];
            s[0] = new SqlParameter("@ActionType", ActionType.Select);
            s[1] = new SqlParameter("@InvoiceNo", InvoiceNo);
            return db.sp_Table("sp_ReturnPuchase", s);
        }

        public static DataTable showreturnPur()
        {
            SqlParameter[] s = new SqlParameter[1];
            s[0] = new SqlParameter("@ActionType", ActionType.Select);
            return db.sp_Table("sp_PurchaseReturnShow", s);
        }
    }
}
