using PharmacyMgt.BL;
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
    public class BL_Admin
    {
        public int adminid { get; set; }

        public string adminname { get; set; }

        public string adminemail { get; set; }

        public string admincontact { get; set; }
        public string adminpassword { get; set; }
        public string adminCnic { get; set; }
        public string adminaddress { get; set; }
        public string adminimage { get; set; }
        public bool IsNew { get; set; }

        public void Profile(int id)
        {
            //adminid = id;
            //SqlParameter[] p = new SqlParameter[2];
            //p[0] = new SqlParameter("@ActionType", ActionType.Select);
            //p[1] = new SqlParameter("@adminid", id);
            //DataTable dt = db.sp_Table("sp_Admin", p);
            DataTable dt = db.Table("select * from tb_Admin where AdminId=" + id);
            if(dt.Rows.Count>0)
            {
                adminid = id;
                adminname = dt.Rows[0]["adminName"].ToString();
                adminemail = dt.Rows[0]["adminEmail"].ToString();
                admincontact = dt.Rows[0]["adminContact"].ToString();
                adminpassword = dt.Rows[0]["adminPassword"].ToString();
                adminCnic = dt.Rows[0]["adminCnic"].ToString();
                adminimage = dt.Rows[0]["adminimage"].ToString();
                adminaddress = dt.Rows[0]["adminAddress"].ToString();
                
            }
        }
        
        public void LogIN()
        {
            SqlParameter[] Para = new SqlParameter[3];
            Para[0] =new SqlParameter("@ActionType", ActionType.Select);
            Para[1] =new SqlParameter("@adminemail", adminemail);
            Para[2] =new SqlParameter("@adminpassword", adminpassword);
            DataTable dt = db.sp_Table("sp_Admin",Para);
            if (dt.Rows.Count > 0)
            {
                adminid = Convert.ToInt32(dt.Rows[0]["AdminId"]);
                adminname = dt.Rows[0]["AdminName"].ToString();
                IsNew = true;
            }
            else
            {
                IsNew = false;
            }

        }


        public void SignUp()
        {
            SqlParameter[] m = new SqlParameter[2];
            m[0] = new SqlParameter("@ActionType", ActionType.Select);
            m[1] = new SqlParameter("@adminemail", adminemail);
            DataTable dt = db.sp_Table("sp_Admin", m);
            if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0]["adminid"])!= adminid)
            {
                IsNew = false;
                MyMessage.msg="You have an account already.";
            }
            else
            {
                SqlParameter[] prrrm = new SqlParameter[9];
                if(adminid>0)
                {
                    prrrm[0] = new SqlParameter("@ActionType", ActionType.Update);
                    MyMessage.msg = "Your Profile has been Updated.";
                }
                else
                {
                    IsNew = true;
                    prrrm[0] = new SqlParameter("ActionType", ActionType.Insert);
                    MyMessage.msg = "You are Signed Up";
                }
                prrrm[1] = new SqlParameter("@adminname", adminname);
                prrrm[2] = new SqlParameter("@adminemail", adminemail);
                prrrm[3] = new SqlParameter("@admincontact", admincontact);
                prrrm[4] = new SqlParameter("@adminpassword", adminpassword);
                prrrm[5] = new SqlParameter("@admincnic", adminCnic);
                prrrm[6] = new SqlParameter("@adminaddress", adminaddress);
                prrrm[7] = new SqlParameter("@adminid", adminid);
                prrrm[8] = new SqlParameter("@adminimage", adminimage);
                db.sp_Query("sp_Admin", prrrm);
            }
        }

    }
}
