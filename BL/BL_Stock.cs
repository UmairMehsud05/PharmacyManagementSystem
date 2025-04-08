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
    public class BL_Stock
    {
        public int StockId { get; set; }
        public int MedicineId { get; set; }
        public string InvoiceNo { get; set; }
        public int TotalQTY { get; set; }
        public int AvailableQTY { get; set; }
        public int SoldQTY { get; set; }
        public double PPrice { get; set; }
        public DateTime Date { get; set; }
        public int Status { get; set; }
        

        public void InsertStock()
        {
            SqlParameter[] p = new SqlParameter[9];
            p[0] = new SqlParameter("@ActionType", ActionType.Insert);
            p[1] = new SqlParameter("@MedicineId", MedicineId);
            p[2] = new SqlParameter("@InvoiceNo", InvoiceNo);
            p[3] = new SqlParameter("@TotalQTY", TotalQTY);
            p[4] = new SqlParameter("@AvailableQTY", AvailableQTY);
            p[5] = new SqlParameter("@SoldQTY", SoldQTY);
            p[6] = new SqlParameter("@PPrice", PPrice);
            p[7] = new SqlParameter("@Date", Date);
            p[8] = new SqlParameter("@Status", Status);
            db.sp_Query("sp_Stock", p);
        }

        public static DataTable SelectStock(int status)
        {
            SqlParameter[] p = new SqlParameter[2];
            p[0] = new SqlParameter("@ActionType", ActionType.Select);
            p[1] = new SqlParameter("@Status", status);
            return db.sp_Table("sp_Stock", p);
        }

        public static DataTable Stock(string InvoiceNo,int MedicineId)
        {
            SqlParameter[] p = new SqlParameter[3];
            p[0] = new SqlParameter("@ActionType", ActionType.Select);
            p[1] = new SqlParameter("@InvoiceNo", InvoiceNo);
            p[2] = new SqlParameter("@MedicineId", MedicineId);
            return db.sp_Table("sp_Stock", p);
        }

        public static DataTable salereturnstock(int MedicineId)
        {
            SqlParameter[] p = new SqlParameter[2];
            p[0] = new SqlParameter("@ActionType", ActionType.Select);
            p[1] = new SqlParameter("@MedicineId", MedicineId);
            return db.sp_Table("sp_Stock", p);
        }

        public void updateStock(int StockId)
        {
            SqlParameter[] p = new SqlParameter[4];
            p[0] = new SqlParameter("@ActionType", ActionType.Update);
            p[1] = new SqlParameter("@TotalQTY", TotalQTY);
            p[2] = new SqlParameter("@AvailableQTY", AvailableQTY);
            p[3] = new SqlParameter("@StockId", StockId);
            db.sp_Query("sp_Stock", p);
        }

        public static DataTable saleQty(int medid)
        {
            SqlParameter[] p = new SqlParameter[2];
            p[0] = new SqlParameter("@ActionType", ActionType.Select);
            p[1] = new SqlParameter("@MedicineId", medid);
            return db.sp_Table("sp_Stock", p);
        }

        public void updtStock(int StockId, int AvailableQTY,int soldQty,int status)
        {
            SqlParameter[] p = new SqlParameter[5];
            p[0] = new SqlParameter("@ActionType", ActionType.Update);
            p[1] = new SqlParameter("@AvailableQTY", AvailableQTY);
            p[2] = new SqlParameter("@SoldQTY", soldQty);
            p[3] = new SqlParameter("@Status", status);
            p[4] = new SqlParameter("@StockId", StockId);
            db.sp_Table("sp_SaleStock", p);
        }

        public void updtedStock(int StockId)
        {
            SqlParameter[] p = new SqlParameter[5];
            p[0] = new SqlParameter("@ActionType", ActionType.Update);
            p[1] = new SqlParameter("@AvailableQTY", AvailableQTY);
            p[2] = new SqlParameter("@SoldQTY", SoldQTY);
            p[3] = new SqlParameter("@Status", Status);
            p[4] = new SqlParameter("@StockId", StockId);
            db.sp_Table("sp_SaleStock", p);
        }

        public static DataTable StockReport()
        {
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@ActionType", ActionType.Select);
            return db.sp_Table("sp_Stock", p);
        }

    }
}
