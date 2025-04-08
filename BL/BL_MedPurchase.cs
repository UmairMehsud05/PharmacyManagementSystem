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
    class BL_MedPurchase
    {
            public int PurchaseId { get; set; }
            public int MedicineId { get; set; }
            public string InvoiceNo { get; set; }
            public int Qty { get; set; }
            public double PPrice { get; set; }
            public int Discount { get; set; }
            public int Bonus { get; set; }
            public DateTime PDate { get; set; }
            public int PStatus { get; set; }


            public void InsertMedPurchase()
            {
                SqlParameter[] p = new SqlParameter[9];
                p[0] = new SqlParameter("@ActionType", ActionType.Insert);
                p[1] = new SqlParameter("@MedicineId", MedicineId);
                p[2] = new SqlParameter("@InvoiceNo", InvoiceNo);
                p[3] = new SqlParameter("@Qty", Qty);
                p[4] = new SqlParameter("@PPrice", PPrice);
                p[5] = new SqlParameter("@Discount", Discount);
                p[6] = new SqlParameter("@Bonus", Bonus);
                p[7] = new SqlParameter("@PDate", DateTime.Now);
                p[8] = new SqlParameter("@PStatus", PStatus);
                db.sp_Query("sp_MedPurchase", p);
                MyMessage.msg = "MedPurchase has been Added";
            }

            public void UpdatePur(int PurchaseId)
            {
                SqlParameter[] pr = new SqlParameter[3];
                pr[0] = new SqlParameter("@ActionType", ActionType.Update);
                pr[1] = new SqlParameter("@Qty", Qty);
                pr[2] = new SqlParameter("@PurchaseId", PurchaseId);
                db.sp_Query("sp_MedPurchaseUpdate", pr);
            }

            public static DataTable AllPurchase(int status)
            {
                SqlParameter[] pr = new SqlParameter[2];
                pr[0] = new SqlParameter("@ActionType", ActionType.Select);
                pr[1] = new SqlParameter("@PStatus", status);
                return db.sp_Table("sp_MedPurchase", pr);
            }

            public static DataTable Purchase(string InvoiceNo, int MedicineId)
            {
                SqlParameter[] pr = new SqlParameter[2];
                pr[0] = new SqlParameter("@ActionType", ActionType.Select);
                pr[1] = new SqlParameter("@InvoiceNo", InvoiceNo);
                pr[1] = new SqlParameter("@MedicineId", MedicineId);
                return db.sp_Table("sp_MedPurchase", pr);
            }

            public void Update(string Invoice)
            {
                SqlParameter[] p = new SqlParameter[3];
                p[0] = new SqlParameter("@ActionType", ActionType.Update);
                p[1] = new SqlParameter("@PStatus", PStatus);
                p[2] = new SqlParameter("@InvoiceNo", Invoice);
                db.sp_Query("sp_MedPurchase", p);
            }

            public static DataTable PurDetails(string InvoiceNo)
            {
                SqlParameter[] pe = new SqlParameter[2];
                pe[0] = new SqlParameter("@ActionType", ActionType.Select);
                pe[1] = new SqlParameter("@InvoiceNo", InvoiceNo);
                return db.sp_Table("sp_MedPurDetails", pe);
            }

            public static DataTable purchase(string InvoiceNo, int MedicineId)
            {
                SqlParameter[] pe = new SqlParameter[3];
                pe[0] = new SqlParameter("@ActionType", ActionType.Select);
                pe[1] = new SqlParameter("@InvoiceNo", InvoiceNo);
                pe[2] = new SqlParameter("@MedicineId", MedicineId);
                return db.sp_Table("sp_MedPurchaseUpdate", pe);
            }

            public static DataTable PurchaseReport()
            {
                SqlParameter[] pr = new SqlParameter[1];
                pr[0] = new SqlParameter("@ActionType", ActionType.Select);
                return db.sp_Table("sp_MedPurchase", pr);
            }

        }
    }