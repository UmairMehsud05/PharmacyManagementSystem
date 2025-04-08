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
    public class BL_Manufacturer
    {
        public int ManufacturerID { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string ManagerName { get; set; }
        public int Gender { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public int Status { get; set; }
        public string Logo { get; set; }
        public bool IsNew { get; set; }



        public static DataTable AllManufacturer(int Status)
        {
            SqlParameter[] pms = new SqlParameter[2];
            pms[0] = new SqlParameter("@ActionType", ActionType.Select); 
            pms[1] = new SqlParameter("@Status", Status);
            return db.sp_Table("sp_Manufacturer", pms);
        }

        public static DataTable SearchManufacture(string CompanyName=null,string Email=null)
        {
            SqlParameter[] pms = new SqlParameter[3];
            pms[0] = new SqlParameter("@ActionType", ActionType.Select);
            pms[1] = new SqlParameter("@CompanyName", CompanyName);
            pms[2] = new SqlParameter("@Email", Email);
            return db.sp_Table("sp_Manufacturer", pms);
        }
        public void AddOrUpdate()
        {
            SqlParameter[] a = new SqlParameter[3];
            a[0] = new SqlParameter("@ActionType", ActionType.Select);
            a[1] = new SqlParameter("@CompanyName", CompanyName);
            a[2] = new SqlParameter("@Email", Email);
            DataTable dt = db.sp_Table("sp_Manufacturer", a);
            if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0]["ManufacturerID"]) != ManufacturerID)
            {
                MyMessage.msg = "Company name already added. Try different one.";
            }
            else
            {
                SqlParameter[] sa = new SqlParameter[10];
                if (IsNew == true)
                {
                    sa[0] = new SqlParameter("@ActionType", ActionType.Insert);
                    MyMessage.msg = "Data has been Added";
                }
                else
                {
                    sa[0] = new SqlParameter("@ActionType",ActionType.Update);
                    MyMessage.msg = "Data has been Updated.";
                }
                    sa[1] = new SqlParameter("@CompanyName", CompanyName);
                    sa[2] = new SqlParameter("@Email", Email);
                    sa[3] = new SqlParameter("@Contact", Contact);
                    sa[4] = new SqlParameter("@ManagerName", ManagerName);
                    sa[5] = new SqlParameter("@Gender", Gender);
                    sa[6] = new SqlParameter("@Address", Address);
                    sa[7] = new SqlParameter("@ZipCode", ZipCode);
                    sa[8] = new SqlParameter("@Status", Status);
                    sa[9] = new SqlParameter("@ManufacturerID", ManufacturerID);
                    db.sp_Query("sp_Manufacturer", sa);
            }
                
       }
        public BL_Manufacturer()
        {

        }

        public BL_Manufacturer(int id)
        {
            SqlParameter[] sid = new SqlParameter[2];
            sid[0] = new SqlParameter("@ActionType", ActionType.Select);
            sid[1] = new SqlParameter("@ManufacturerID", id);
            DataTable dt = db.sp_Table("sp_Manufacturer", sid);
            if(dt.Rows.Count>0)
            {
                ManufacturerID = Convert.ToInt32(dt.Rows[0]["ManufacturerID"]);
                CompanyName = dt.Rows[0]["CompanyName"].ToString();
                Email = dt.Rows[0]["Email"].ToString();
                Contact = dt.Rows[0]["Contact"].ToString();
                ManagerName = dt.Rows[0]["ManagerName"].ToString();
                Gender = Convert.ToInt32(dt.Rows[0]["Gender"]);
                Address = dt.Rows[0]["Address"].ToString();
                ZipCode = dt.Rows[0]["ZipCode"].ToString();
                Status = Convert.ToInt32(dt.Rows[0]["Status"]);
            }
            
        }

        public void Delete()
        {
            SqlParameter[] sidd = new SqlParameter[2];
            sidd[0] = new SqlParameter("@ActionType", ActionType.Delete);
            sidd[1] = new SqlParameter("@ManufacturerID", ManufacturerID);
            db.sp_Query("sp_Manufacturer", sidd);
            MyMessage.msg = "Manufactuere Deleted";
        }

        public static DataTable ManufacturerReport()
        {
            SqlParameter[] pms = new SqlParameter[1];
            pms[0] = new SqlParameter("@ActionType", ActionType.Select);
            return db.sp_Table("sp_Manufacturer", pms);
        }

    }
} 
