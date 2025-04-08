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
    public class BL_Category
    {
        public int CatID { get; set; }
        public string CatName { get; set; }
        public int CatStatus { get; set; }
        public string displaystatus { get; set; }
        public bool IsNew { get; set; }

        public BL_Category()
        {

        }

        public BL_Category(int id)
        {
            SqlParameter[] p = new SqlParameter[2];
            p[0] = new SqlParameter("@ActionType", ActionType.Select);
            p[1] = new SqlParameter("@CatID", id);
            DataTable dt = db.sp_Table("sp_Category", p);
            if (dt.Rows.Count > 0)
            {
                CatID = Convert.ToInt32(dt.Rows[0]["CatID"]);
                CatName = dt.Rows[0]["CatName"].ToString();
                displaystatus = Convert.ToString(dt.Rows[0]["Status"]);

            }
        }

        public void AddOrUpdate()
        {
            SqlParameter[] p = new SqlParameter[2];
            p[0] = new SqlParameter("@ActionType", ActionType.Select);
            p[1] = new SqlParameter("@CatName", CatName);
            DataTable dt = db.sp_Table("sp_Category", p);
            if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0]["CatID"]) != CatID)
            {
                MyMessage.msg = "Already added this Category, try another one";
            }
            else
            {
                SqlParameter[] prm = new SqlParameter[4];
                if(CatID > 0)
                    prm[0] = new SqlParameter("@ActionType", ActionType.Update);
                else
                    prm[0] = new SqlParameter("@ActionType", ActionType.Insert);
                prm[1] = new SqlParameter("@CatID", CatID);
                prm[2] = new SqlParameter("@CatName", CatName);
                prm[3] = new SqlParameter("@CatStatus", CatStatus);
                if (IsNew == true)
                {
                    MyMessage.msg = "Category has been added";
                }
                else
                {
                    MyMessage.msg = "Category has been updated";
                }
                db.sp_Query("sp_Category", prm);
            }
        }

        public static DataTable AllCat(int CatStatus)
        {
            SqlParameter[] prt = new SqlParameter[2];
            prt[0] = new SqlParameter("@ActionType", ActionType.Select);
            prt[1] = new SqlParameter("@CatStatus", CatStatus);
            return db.sp_Table("sp_Category",prt);
        }

        public void DeleteCat()
        {
            SqlParameter[] prms = new SqlParameter[2];
            prms[0] = new SqlParameter("@ActionType", ActionType.Delete);
            prms[1] = new SqlParameter("@CatID", CatID);
            db.sp_Table("sp_Category", prms);
            MyMessage.msg = "Category Deleted";
        }

        public static DataTable AllCategory()
        {
            SqlParameter[] prmt = new SqlParameter[1];
            prmt[0] = new SqlParameter("@ActionType", ActionType.Select);
            return db.sp_Table("sp_Category", prmt);
        }

    }
}
