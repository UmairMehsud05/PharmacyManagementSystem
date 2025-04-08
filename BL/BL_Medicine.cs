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
    public class BL_Medicine
    {
        public int MedID { get; set; }
        public int UnitID { get; set; }
        public int CatID { get; set; }
        public int SubCatID { get; set; }
        public int ManufacturerID { get; set; }
        public string MedName { get; set; }
        public string MedFormula { get; set; }
        public string Description { get; set; }
        public int MedStatus { get; set; }
        public bool IsNew { get; set; }


        public static DataTable SubCategoryByCatId(int catid)
        {
            int Status = 1;
            SqlParameter[] p = new SqlParameter[3];
            p[0] = new SqlParameter("@ActionType", ActionType.Select);
            p[1] = new SqlParameter("@CatID", catid);
            p[2] = new SqlParameter("@Status", Status);
            DataTable dt = db.sp_Table("sp_SubCategory",p);
            return dt;
        }

        public static DataTable AllMedicine(int MedStatus)
        {
            SqlParameter[] prmt = new SqlParameter[2];
            prmt[0] = new SqlParameter("@ActionType", ActionType.Select);
            prmt[1] = new SqlParameter("@MedStatus", MedStatus);
            DataTable dt = db.sp_Table("sp_Medicine", prmt);
            return dt;
        }

        public static DataTable SearchMedicine(string MedName = null, string MedFormula = null,int ? UnitID=null, int? CatID=null, int? ManufacturerID=null)
        {
            SqlParameter[] prmt = new SqlParameter[6];
            prmt[0] = new SqlParameter("@ActionType", ActionType.Select);
            prmt[1] = new SqlParameter("@UnitID", UnitID);
            prmt[2] = new SqlParameter("@CatID", CatID);
            prmt[3] = new SqlParameter("@ManufacturerID", ManufacturerID);
            prmt[4] = new SqlParameter("@MedName", MedName);
            prmt[5] = new SqlParameter("@MedFormula", MedFormula);
            DataTable dt = db.sp_Table("sp_Medicine", prmt);
            return dt;
        }

        public BL_Medicine()
        {

        }

        public BL_Medicine(int id)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter("@ActionType", ActionType.Select);
            pr[1] = new SqlParameter("@MedID", id);
            DataTable dt = db.sp_Table("sp_Medicine", pr);
            MedID = id;
            UnitID = Convert.ToInt32(dt.Rows[0]["UnitID"]);
            ManufacturerID = Convert.ToInt32(dt.Rows[0]["ManufacturerID"]);
            CatID = Convert.ToInt32(dt.Rows[0]["CatID"]);
            SubCatID = Convert.ToInt32(dt.Rows[0]["SubCatID"]);
            MedName = dt.Rows[0]["MedName"].ToString();
            MedFormula = dt.Rows[0]["MedFormula"].ToString();
            Description = dt.Rows[0]["Description"].ToString();
            MedStatus = Convert.ToInt32(dt.Rows[0]["MedStatus"]);
        }

        public void Delete()
        {
            SqlParameter[] prr = new SqlParameter[2];
            prr[0] = new SqlParameter("@ActionType", ActionType.Delete);
            prr[1] = new SqlParameter("@MedID", MedID);
            db.sp_Query("sp_Medicine", prr);
            MyMessage.msg = "Medicine Deleted";
        }

        public void AddOrUpdate()
        {
            SqlParameter[] prmm = new SqlParameter[2];
            prmm[0] = new SqlParameter("@ActionType", ActionType.Select);
            prmm[1] = new SqlParameter("@MedName", MedName);
            DataTable dt = db.sp_Table("sp_Medicine", prmm);
            if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0]["MedID"]) != MedID)
            {
                MyMessage.msg = "Already added this Medicine, try different one!";
            }
            else
            {
                SqlParameter[] pm = new SqlParameter[10];
                if (IsNew == true)
                {
                    pm[0] = new SqlParameter("@ActionType", ActionType.Insert);
                    MyMessage.msg = "Data has been Added successfully";
                }
                else
                {
                    pm[0] = new SqlParameter("@ActionType", ActionType.Update);
                    MyMessage.msg = "Data has been Updated successfully";
                }
                pm[1] = new SqlParameter("@UnitID", UnitID);
                pm[2] = new SqlParameter("@CatID", CatID);
                pm[3] = new SqlParameter("@SubCatID", SubCatID);
                pm[4] = new SqlParameter("@ManufacturerID", ManufacturerID);
                pm[5] = new SqlParameter("@MedName", MedName);
                pm[6] = new SqlParameter("@MedFormula", MedFormula);
                pm[7] = new SqlParameter("@Description", Description);
                pm[8] = new SqlParameter("@MedStatus", MedStatus);
                pm[9] = new SqlParameter("@MedID", MedID);
                db.sp_Query("sp_Medicine", pm);
            }
        }

        public static DataTable MedicineReport()
        {
            SqlParameter[] prmt = new SqlParameter[1];
            prmt[0] = new SqlParameter("@ActionType", ActionType.Select);
            DataTable dt = db.sp_Table("sp_Medicine", prmt);
            return dt;
        }
    }
}
