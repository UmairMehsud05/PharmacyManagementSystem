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
    public class BL_MedSale
    {
        public int SaleId { get; set; }
        public int MedicineId { get; set; }
        public int InvoiceNo { get; set; }
        public int QTY { get; set; }
        public double SalePrice { get; set; }
        public int Discount { get; set; }
        public DateTime SaleDate { get; set; }
        public int SStatus { get; set; }


        public void InsertSale()
        {
            SqlParameter[] s = new SqlParameter[8];
            s[0] = new SqlParameter("@ActionType", ActionType.Insert);
            s[1] = new SqlParameter("@MedicineId", MedicineId);
            s[2] = new SqlParameter("@InvoiceNo", InvoiceNo);
            s[3] = new SqlParameter("@QTY", QTY);
            s[4] = new SqlParameter("@SalePrice", SalePrice);
            s[5] = new SqlParameter("@Discount", Discount);
            s[6] = new SqlParameter("@SaleDate", SaleDate);
            s[7] = new SqlParameter("@SStatus", SStatus);
            db.sp_Query("sp_MedSale", s);
            MyMessage.msg = "MedSale has been Added";
        }

        public static DataTable AllSale(int status)
        {
            SqlParameter[] s = new SqlParameter[2];
            s[0] = new SqlParameter("@ActionType", ActionType.Select);
            s[1] = new SqlParameter("@SStatus", status);
            return db.sp_Table("sp_MedSale", s);
        }

        public void UpdateSale(string Invoice, int status)
        {
            SqlParameter[] s = new SqlParameter[3];
            s[0] = new SqlParameter("@ActionType", ActionType.Update);
            s[1] = new SqlParameter("@SStatus", status);
            s[2] = new SqlParameter("@InvoiceNo", Invoice);
            db.sp_Query("sp_MedSale", s);
        }

        public static DataTable SaleDetail(string invoice)
        {
            SqlParameter[] s = new SqlParameter[2];
            s[0] = new SqlParameter("@ActionType", ActionType.Select);
            s[1] = new SqlParameter("@InvoiceNo", invoice);
            return db.sp_Table("sp_MedSaleDetails", s);
        }

        public static DataTable Sale(int medid, string invoiceNo)
        {
            SqlParameter[] s = new SqlParameter[3];
            s[0] = new SqlParameter("@ActionType", ActionType.Select);
            s[1] = new SqlParameter("@MedicineId", medid);
            s[2] = new SqlParameter("@InvoiceNo", invoiceNo);
            return db.sp_Table("sp_MedRetSale", s);
        }

        public void UpdateRetSale(int SaleId)
        {
            SqlParameter[] s = new SqlParameter[3];
            s[0] = new SqlParameter("@ActionType", ActionType.Update);
            s[1] = new SqlParameter("@QTY", QTY);
            s[2] = new SqlParameter("@SaleId", SaleId);
            db.sp_Query("sp_MedSalee", s);
        }

        public static DataTable SaleReport()
        {
            SqlParameter[] s = new SqlParameter[1];
            s[0] = new SqlParameter("@ActionType", ActionType.Select);
            return db.sp_Table("sp_MedSale", s);
        }

    }
}