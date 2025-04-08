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
    public class BL_Customer
    {
        public int customerID { get; set; }

        public string customerName { get; set; }

        public string customerEmail { get; set; }

        public string customerContact { get; set; }

        public string customerAddress { get; set; }

        public string customerCNIC { get; set; }

        public int customerStatus { get; set; }

        public bool IsNew { get; set; }


        public static DataTable AllCustomer(int customerStatus)
        {
            SqlParameter[] pms = new SqlParameter[2];
            pms[0] = new SqlParameter("@ActionType", ActionType.Select);
            pms[1] = new SqlParameter("@customerStatus", customerStatus);
            DataTable dt = db.sp_Table("sp_Customer",pms);
            return dt;
        }

        public static DataTable SearchCustomer(string customerName=null,string customerEmail=null,string customerCNIC=null)
        {
            SqlParameter[] pms = new SqlParameter[4];
            pms[0] = new SqlParameter("@ActionType", ActionType.Select);
            pms[1] = new SqlParameter("@customerName", customerName);
            pms[2] = new SqlParameter("@customerEmail", customerEmail);
            pms[3] = new SqlParameter("@customerCNIC", customerCNIC);
            DataTable dt = db.sp_Table("sp_Customer", pms);
            return dt;
        }

        public BL_Customer()
        {

        }

        public BL_Customer(int id)
        {
            SqlParameter[] prmg = new SqlParameter[2];
            prmg[0] = new SqlParameter("@ActionType", ActionType.Select);
            prmg[1] = new SqlParameter("@customerID", id);
            DataTable dt = db.sp_Table("sp_Customer",prmg);
            if (dt.Rows.Count>0)
            {
                customerID = Convert.ToInt32(dt.Rows[0]["customerID"]);
                customerName = dt.Rows[0]["customerName"].ToString();
                customerEmail = dt.Rows[0]["customerEmail"].ToString();
                customerContact = dt.Rows[0]["customerContact"].ToString();
                customerAddress = dt.Rows[0]["customerAddress"].ToString();
                customerCNIC = dt.Rows[0]["customerCNIC"].ToString();
                customerStatus = Convert.ToInt32(dt.Rows[0]["customerStatus"]);
            }
        }

        public void deleteCustomer()
        {
            SqlParameter[] pm = new SqlParameter[2];
            pm[0] = new SqlParameter("@ActionType", ActionType.Delete);
            pm[1] = new SqlParameter("@customerID", customerID);
            db.sp_Query("sp_Customer",pm);
            MyMessage.msg="Data has been deleted";
        }
        public void AddOrUpdate()
        {
            SqlParameter[] p = new SqlParameter[3];
            p[0] = new SqlParameter("@ActionType", ActionType.Select);
            p[1] = new SqlParameter("@customerEmail", customerEmail);
            p[2] = new SqlParameter("@customerCNIC", customerCNIC);
            DataTable dt = db.sp_Table("sp_Customer", p);
            if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0]["customerID"]) != customerID)
            {
                MyMessage.msg = "Already added this Customer, try another one";
            }
            else
            {
                SqlParameter[] prr = new SqlParameter[8];
                if (IsNew == true)
                {

                    prr[0] = new SqlParameter("@ActionType", ActionType.Insert);
                    MyMessage.msg = "Customer has been Added";
                }
                else
                {
                    prr[0] = new SqlParameter("@ActionType", ActionType.Update);
                    MyMessage.msg = "Customer has been updated";
                }
                prr[1] = new SqlParameter("@customerID", customerID);
                prr[2] = new SqlParameter("@customerName", customerName);
                prr[3] = new SqlParameter("@customerEmail", customerEmail);
                prr[4] = new SqlParameter("@customerContact", customerContact);
                prr[5] = new SqlParameter("@customerAddress", customerAddress);
                prr[6] = new SqlParameter("@customerCNIC", customerCNIC);
                prr[7] = new SqlParameter("@customerStatus", customerStatus);
                db.sp_Query("sp_Customer", prr);
            }
        }

        public static DataTable CustomerReport()
        {
            SqlParameter[] pms = new SqlParameter[1];
            pms[0] = new SqlParameter("@ActionType", ActionType.Select);
            DataTable dt = db.sp_Table("sp_Customer", pms);
            return dt;
        }
    }
}
