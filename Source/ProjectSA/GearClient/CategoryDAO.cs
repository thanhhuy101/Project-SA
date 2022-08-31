using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace GearClient
{
    public class CategoryDAO
    {
        string strGear = ConfigurationManager.ConnectionStrings["strGear"].ConnectionString;

        public List<Category> SelectAll()
        {
            List<Category> categories = new List<Category>();
            SqlConnection con = new SqlConnection(strGear);
            con.Open();
            string strCom = "SELECT * FROM CategoryGear";
            SqlCommand com = new SqlCommand(strCom, con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Category category = new Category()
                {
                    CategoryID = (int)dr["CategoryID"],
                    CategoryName = (string)dr["CategoryName"]
                };
                categories.Add(category);
            }
            con.Close();
            return categories;
        }


        public Category SelectByCode(int CategoryID)
        {
            Category category = null;
            SqlConnection con = new SqlConnection(strGear);
            con.Open();
            String strCom = "SELECT * FROM CategoryGear WHERE CategoryID=@CategoryID";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@CategoryID", CategoryID));
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                category = new Category()
                {
                    CategoryID = (int)dr["CategoryID"],
                    CategoryName = (string)dr["CategoryName"]
                };
            }
            con.Close();
            return category;
        }

        public List<Category> SelectByKeyword(string keyword)
        {
            List<Category> categories = new List<Category>();
            SqlConnection con = new SqlConnection(strGear);
            con.Open();
            string strCom = "SELECT * FROM CategoryGear WHERE CategoryName LIKE @Keyword";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("Keyword", "%" + keyword + "%"));
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Category category = new Category()
                {
                    CategoryID = (int)dr["CategoryID"],
                    CategoryName = (string)dr["CategoryName"]
                };
                categories.Add(category);
            }
            con.Close();
            return categories;
        }

        public bool Insert(Category newCategory)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(strGear);
            con.Open();
            String strCom = "INSERT INTO CategoryGear (CategoryName) VALUES (@CategoryName)";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@CategoryName", newCategory.CategoryName));
            try { result = com.ExecuteNonQuery() > 0; }
            catch { result = false; }
            con.Close();
            return result;
        }

        public bool Update(Category newCategory)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(strGear);
            con.Open();
            String strCom = "UPDATE CategoryGear SET CategoryName=@CategoryName WHERE CategoryID=@CategoryID";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@CategoryName", newCategory.CategoryName));
            com.Parameters.Add(new SqlParameter("@CategoryID", newCategory.CategoryID));
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

        public bool Delete(int CategoryID)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(strGear);
            con.Open();
            string strCom = "DELETE FROM CategoryGear WHERE CategoryID=@CategoryID";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@CategoryID", CategoryID));
            try { result = com.ExecuteNonQuery() > 0; }
            catch { result = false; }
            con.Close();
            return result;
        }

        public DataSet GetAllCategory()
        {
            SqlConnection con = new SqlConnection(strGear);
            DataSet dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM CategoryGear", con);

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
