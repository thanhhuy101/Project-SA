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
    public class BrandDAO
    {
        string strGear = ConfigurationManager.ConnectionStrings["strGear"].ConnectionString;

        public List<Brand> SelectAll()
        {
            List<Brand> brands = new List<Brand>();
            SqlConnection con = new SqlConnection(strGear);
            con.Open();
            string strCom = "SELECT * FROM BrandGear";
            SqlCommand com = new SqlCommand(strCom, con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Brand brand = new Brand()
                {
                    BrandGearID = (int)dr["BrandGearID"],
                    BrandGearName = (string)dr["BrandGearName"]
                };
                brands.Add(brand);
            }
            con.Close();
            return brands;
        }


        public Brand SelectByCode(int BrandID)
        {
            Brand brand = null;
            SqlConnection con = new SqlConnection(strGear);
            con.Open();
            String strCom = "SELECT * FROM BrandGear WHERE BrandGearID=@BrandGearID";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@BrandGearID", BrandID));
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                brand = new Brand()
                {
                    BrandGearID = (int)dr["BrandGearID"],
                    BrandGearName = (string)dr["BrandGearName"]
                };
            }
            con.Close();
            return brand;
        }

        public List<Brand> SelectByKeyword(string keyword)
        {
            List<Brand> brands = new List<Brand>();
            SqlConnection con = new SqlConnection(strGear);
            con.Open();
            string strCom = "SELECT * FROM BrandGear WHERE BrandGearName LIKE @Keyword";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("Keyword", "%" + keyword + "%"));
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Brand brand = new Brand()
                {
                    BrandGearID = (int)dr["BrandGearID"],
                    BrandGearName = (string)dr["BrandGearName"]
                };
                brands.Add(brand);
            }
            con.Close();
            return brands;
        }

        public bool Insert(Brand newBrand)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(strGear);
            con.Open();
            String strCom = "INSERT INTO BrandGear (BrandGearName) VALUES (@BrandGearName)";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@BrandGearName", newBrand.BrandGearName));
            try { result = com.ExecuteNonQuery() > 0; }
            catch { result = false; }
            con.Close();
            return result;
        }

        public bool Update(Brand newBrand)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(strGear);
            con.Open();
            String strCom = "UPDATE BrandGear SET BrandGearName=@BrandGearName WHERE BrandGearID=@BrandGearID";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@BrandGearName", newBrand.BrandGearName));
            com.Parameters.Add(new SqlParameter("@BrandGearID", newBrand.BrandGearID));
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

        public bool Delete(int BrandID)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(strGear);
            con.Open();
            string strCom = "DELETE FROM BrandGear WHERE BrandGearID=@BrandGearID";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@BrandGearID", BrandID));
            try { result = com.ExecuteNonQuery() > 0; }
            catch { result = false; }
            con.Close();
            return result;
        }

        public DataSet GetAllBrand()
        {
            SqlConnection con = new SqlConnection(strGear);
            DataSet dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM BrandGear", con);

            try
            {
                con.Open();
                adapter.Fill(dataSet);
                con.Close();
            }
            catch (Exception ex)
            {
                return null;
            }
            return dataSet;
        }
    }
}
