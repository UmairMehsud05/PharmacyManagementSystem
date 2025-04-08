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
    public class BL_SubCategory
    {
        public int SubCatID { get; set; }
        public int CatID { get; set; }
        public string SubCatName { get; set; }
        public int Status { get; set; }
        public bool IsNew { get; set; }


        public static DataTable AllSubCategory(int Status)
        {
            SqlParameter[] pl = new SqlParameter[2];
            pl[0] = new SqlParameter("@ActionType", ActionType.Select);
            pl[1] = new SqlParameter("@Status", Status);
            DataTable dt = db.sp_Table("sp_SubCategory",pl);
            return dt;
        }

        public void AddOrUpdate()
        {
            SqlParameter[] ap = new SqlParameter[3];
            ap[0] = new SqlParameter("@ActionType", ActionType.Select);
            ap[1] = new SqlParameter("@CatID", CatID);
            ap[2] = new SqlParameter("@SubCatName", SubCatName);
            DataTable dt = db.sp_Table("sp_SubCategory", ap);
            if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0]["SubCatID"]) != SubCatID)
            {
                MyMessage.msg = "Already added this Sub-Category, try different one.";
            }
            else
            {
                SqlParameter[] app = new SqlParameter[5];
                if (IsNew == true)
                {
                    app[0] = new SqlParameter("@ActionType", ActionType.Insert);
                    MyMessage.msg = "Data has been Added";
                }
                else
                {
                    app[0] = new SqlParameter("@ActionType", ActionType.Update);
                    MyMessage.msg = "Data has been Updated";
                }
                app[1] = new SqlParameter("@CatID", CatID);
                app[2] = new SqlParameter("@SubCatName", SubCatName);
                app[3] = new SqlParameter("@Status", Status);
                app[4] = new SqlParameter("@SubCatID", SubCatID);
                db.sp_Query("sp_SubCategory", app);
            }

        }


        public void Delete()
        {
            SqlParameter[] sqp = new SqlParameter[2];
            sqp[0] = new SqlParameter("@ActionType", ActionType.Delete);
            sqp[1] = new SqlParameter("@SubCatID", SubCatID);
            db.sp_Query("sp_SubCategory", sqp);
            MyMessage.msg = "SubCategory Deleted";
        }

        public BL_SubCategory()
        {

        }


        public BL_SubCategory(int id)
        {
            SqlParameter[] sqpm = new SqlParameter[2];
            sqpm[0] = new SqlParameter("@ActionType", ActionType.Select);
            sqpm[1] = new SqlParameter("@SubCatID", id);
            DataTable dt = db.sp_Table("sp_SubCategory", sqpm);
            if (dt.Rows.Count > 0)
            {
                CatID = Convert.ToInt32(dt.Rows[0]["CatID"]);
                SubCatID = Convert.ToInt32(dt.Rows[0]["SubCatID"]);
                SubCatName = dt.Rows[0]["SubCatName"].ToString();
                Status = Convert.ToInt32(dt.Rows[0]["Status"]);
            }

        }

        public static DataTable load()
        {
            SqlParameter[] sel = new SqlParameter[1];
            sel[0] = new SqlParameter("@ActionType", ActionType.Select);
            DataTable dt = db.sp_Table("sp_Category", sel);
            return dt;
        }

        public static DataTable SubCategoryReport()
        {
            SqlParameter[] pl = new SqlParameter[1];
            pl[0] = new SqlParameter("@ActionType", ActionType.Select);
            DataTable dt = db.sp_Table("sp_SubCategory", pl);
            return dt;
        }

    }
}
