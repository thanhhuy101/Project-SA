using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace GearClient
{
    public class GearDAO
    {
        string strGear = ConfigurationManager.ConnectionStrings["strGear"].ConnectionString;

        public List<Gear> SelectAll()
        {
            List<Gear> gears = new List<Gear>();
            SqlConnection con = new SqlConnection(strGear);
            con.Open();
            string strCom = "SELECT * FROM Gear";
            SqlCommand com = new SqlCommand(strCom, con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Gear gear = new Gear()
                {
                    GearID = (int)dr["GearID"],
                    GearName = (string)dr["GearName"],
                    CategoryID = (int)dr["CategoryID"],
                    BrandID = (int)dr["BrandID"],
                    GearPrice = (int)dr["GearPrice"]
                };
                gears.Add(gear);
            }
            con.Close();
            return gears;
        }


        public Gear SelectByCode(int GearID)
        {
            Gear gear = null;
            SqlConnection con = new SqlConnection(strGear);
            con.Open();
            String strCom = "SELECT * FROM Gear WHERE GearID=@GearID";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@GearID", GearID));
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                gear = new Gear()
                {
                    GearID = (int)dr["GearID"],
                    GearName = (string)dr["GearName"],
                    CategoryID = (int)dr["CategoryID"],
                    BrandID = (int)dr["BrandID"],
                    GearPrice = (int)dr["GearPrice"]
                };
            }
            con.Close();
            return gear;
        }

        public List<Gear> SelectByKeyword(string keyword)
        {
            List<Gear> gears = new List<Gear>();
            SqlConnection con = new SqlConnection(strGear);
            con.Open();
            string strCom = "SELECT * FROM Gear WHERE GearName LIKE @Keyword";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("Keyword", "%" + keyword + "%"));
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Gear gear = new Gear()
                {
                    GearID = (int)dr["GearID"],
                    GearName = (string)dr["GearName"],
                    CategoryID = (int)dr["CategoryID"],
                    BrandID = (int)dr["BrandID"],
                    GearPrice = (int)dr["GearPrice"]
                };
                gears.Add(gear);
            }
            con.Close();
            return gears;
        }

        public bool Insert(Gear newGear)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(strGear);
            con.Open();
            String strCom = "INSERT INTO Gear (GearName, CategoryID, BrandID, GearPrice) VALUES (@GearName, @CategoryID, @BrandID, @GearPrice)";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@GearName", newGear.GearName));
            com.Parameters.Add(new SqlParameter("@CategoryID", newGear.CategoryID));
            com.Parameters.Add(new SqlParameter("@BrandID", newGear.BrandID));
            com.Parameters.Add(new SqlParameter("@GearPrice", newGear.GearPrice));
            try { result = com.ExecuteNonQuery() > 0; }
            catch { result = false; }
            con.Close();
            return result;
        }

        public bool Update(Gear newGear)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(strGear);
            con.Open();
            String strCom = "UPDATE Gear SET GearName=@GearName, CategoryID=@CategoryID, BrandID=@BrandID, GearPrice=@GearPrice WHERE GearID=@GearID";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@GearName", newGear.GearName));
            com.Parameters.Add(new SqlParameter("@CategoryID", newGear.CategoryID));
            com.Parameters.Add(new SqlParameter("@BrandID", newGear.BrandID));
            com.Parameters.Add(new SqlParameter("@GearPrice", newGear.GearPrice));
            com.Parameters.Add(new SqlParameter("@GearID", newGear.GearID));
            try
            {
                result = com.ExecuteNonQuery() > 0;
            }
            catch
            {
                result = false;
            }
            con.Close();
            return result;
        }

        public bool Delete(int GearID)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(strGear);
            con.Open();
            string strCom = "DELETE FROM Gear WHERE GearID=@GearID";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@GearID", GearID));
            try { result = com.ExecuteNonQuery() > 0; }
            catch { result = false; }
            con.Close();
            return result;
        }

        public DataSet getAllData()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=sql.bsite.net\\MSSQL2016; User Id=thanhhuy101_Gear; Password=123456789; Database=thanhhuy101_Gear";
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from View_Gears", con);
            try
            {
                con.Open();
                adapter.Fill(ds);
                con.Close();
            }
            catch (Exception ex)
            {
                return null;
            }
            return ds;
        }
    }
}
