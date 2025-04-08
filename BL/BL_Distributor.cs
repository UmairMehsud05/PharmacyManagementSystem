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
    public class BL_Distributor
    {
        public int DistributerId { get; set; }

        public string Name { get; set; }

        public string ShopName { get; set; }

        public string Email { get; set; }

        public string Contact { get; set; }

        public string CNIC { get; set; }

        public string Address { get; set; }

        public String PostalCode { get; set; }

        public int Status { get; set; }
        public string image { get; set; }

        public bool Isnew { get; set; }

        public void AddOrUpdate()
        {
            SqlParameter[] s = new SqlParameter[3];
            s[0] = new SqlParameter("@ActionType", ActionType.Select);
            s[1] = new SqlParameter("@Email", Email);
            s[2] = new SqlParameter("@CNIC", CNIC);
            DataTable dt = db.sp_Table("sp_Distributor", s);
            if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0]["DistributerId"]) != DistributerId)
            {
                MyMessage.msg = "ShopName already added. Try different one.";
            }
            else
            {
                SqlParameter[] sp = new SqlParameter[10];
                if (Isnew == true)
                {
                    sp[0] = new SqlParameter("@ActionType", ActionType.Insert);
                    MyMessage.msg = "Data has been Added";
                }
                else
                {
                    sp[0] = new SqlParameter("@ActionType", ActionType.Update);
                    MyMessage.msg = "Data has been Updated";
                }
                sp[1] = new SqlParameter("@Name", Name);
                sp[2] = new SqlParameter("@ShopName", ShopName);
                sp[3] = new SqlParameter("@Email", Email);
                sp[4] = new SqlParameter("@Contact", Contact);
                sp[5] = new SqlParameter("@CNIC", CNIC);
                sp[6] = new SqlParameter("@Address", Address);
                sp[7] = new SqlParameter("@PostalCode", PostalCode);
                sp[8] = new SqlParameter("@Status", Status);
                sp[9] = new SqlParameter("@DistributerId", DistributerId);
                db.sp_Query("sp_Distributor", sp);
            }
        }

        public static DataTable AllDistributor(int Status)
        {
            SqlParameter[] prms = new SqlParameter[2];
            prms[0] = new SqlParameter("@ActionType", ActionType.Select);
            prms[1] = new SqlParameter("@Status", Status);
             DataTable dt = db.sp_Table("sp_Distributor",prms);
            return dt;
        }

        public static DataTable SearchDistributor(string Name = null, string ShopName=null, string Email=null, string CNIC=null)
        {
            SqlParameter[] prms = new SqlParameter[5];
            prms[0] = new SqlParameter("@ActionType", ActionType.Select);
            prms[1] = new SqlParameter("@Name", Name);
            prms[2] = new SqlParameter("@ShopName", ShopName);
            prms[3] = new SqlParameter("@Email", Email);
            prms[4] = new SqlParameter("@CNIC", CNIC);
            DataTable dt = db.sp_Table("sp_Distributor", prms);
            return dt;
        }

        public BL_Distributor()
        {

        }

        public BL_Distributor(int id)
        {
            SqlParameter[] spar = new SqlParameter[2];
            spar[0] = new SqlParameter("@ActionType", ActionType.Select);
            spar[1] = new SqlParameter("@DistributerId", id);
            DataTable dt = db.sp_Table("sp_Distributor", spar);
            if (dt.Rows.Count > 0)
            {
                DistributerId = id;
                Name = dt.Rows[0]["Name"].ToString();
                ShopName = dt.Rows[0]["ShopName"].ToString();
                Email = dt.Rows[0]["Email"].ToString();
                Contact = dt.Rows[0]["Contact"].ToString();
                CNIC = dt.Rows[0]["CNIC"].ToString();
                Address = dt.Rows[0]["Address"].ToString();
                PostalCode = dt.Rows[0]["PostalCode"].ToString();
                Status = Convert.ToInt32(dt.Rows[0]["Status"]);
            }

        }

        public void DeleteDistributor()
        {
            SqlParameter[] spara = new SqlParameter[2];
            spara[0] = new SqlParameter("@ActionType",ActionType.Delete);
            spara[1] = new SqlParameter("@DistributerId", DistributerId);
            db.sp_Query("sp_Distributor", spara);
            MyMessage.msg = "Distributor has been Deleted";
        }

        public static DataTable DistributorReport()
        {
            SqlParameter[] prms = new SqlParameter[1];
            prms[0] = new SqlParameter("@ActionType", ActionType.Select);
            DataTable dt = db.sp_Table("sp_Distributor", prms);
            return dt;
        }

    }
}
