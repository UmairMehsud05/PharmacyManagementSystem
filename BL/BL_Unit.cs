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
    public class BL_Unit
    {
        public int UnitID { get; set; }
        public string UnitName { get; set; }
        public int UnitStatus { get; set; }
        public bool IsNew { get; set; }


        public static DataTable AllUnit(int UnitStatus)
        {
            SqlParameter[] prmr = new SqlParameter[2];
            prmr[0] = new SqlParameter("@ActionType", ActionType.Select);
            prmr[1] = new SqlParameter("@UnitStatus", UnitStatus);
            DataTable dt = db.sp_Table("sp_Unit",prmr);
            return dt;
        }

        public BL_Unit()
        {

        }

        public BL_Unit(int id)
        {
            SqlParameter[] sp = new SqlParameter[2];
            sp[0] = new SqlParameter("@ActionType", ActionType.Select);
            sp[1] = new SqlParameter("@UnitID", id);
            DataTable dt = db.sp_Table("sp_Unit", sp);
            if(dt.Rows.Count>0)
            {
                UnitID = Convert.ToInt32(dt.Rows[0]["UnitID"]);
                UnitName = dt.Rows[0]["UnitName"].ToString();
                UnitStatus = Convert.ToInt32(dt.Rows[0]["UnitStatus"]);
            }

        }

        public void Delete()
        {
            SqlParameter[] spp = new SqlParameter[2];
            spp[0] = new SqlParameter("@ActionType", ActionType.Delete);
            spp[1] = new SqlParameter("@UnitID", UnitID);
            db.sp_Query("sp_Unit", spp);
            MyMessage.msg = "Unit Deleted";
        }

        public void AddOrUpdate()
        {
            SqlParameter[] smpp = new SqlParameter[2];
            smpp[0] = new SqlParameter("@ActionType", ActionType.Select);
            smpp[1] = new SqlParameter("@UnitName", UnitName);
            DataTable dt = db.sp_Table("sp_Unit", smpp);
            if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0]["UnitID"]) != UnitID)
            {
                MyMessage.msg="Unit name already added. Try different one.";
            }
            else
            {
                SqlParameter[] smttp = new SqlParameter[4];
                if (IsNew==true)
                {
                    smttp[0] = new SqlParameter("@ActionType",ActionType.Insert);
                    MyMessage.msg = "Data has been Added";
                }
                else
                {
                    smttp[0] = new SqlParameter("@ActionType", ActionType.Update);
                    MyMessage.msg = "Data has been Updated.";
                }
                smttp[1] = new SqlParameter("@UnitName", UnitName);
                smttp[2] = new SqlParameter("@UnitStatus", UnitStatus);
                smttp[3] = new SqlParameter("@UnitID", UnitID);
                db.sp_Query("sp_Unit", smttp);
            }
                
         }

        public static DataTable UnitReport()
        {
            SqlParameter[] prmr = new SqlParameter[1];
            prmr[0] = new SqlParameter("@ActionType", ActionType.Select);
            DataTable dt = db.sp_Table("sp_Unit", prmr);
            return dt;
        }

    }
}
 
