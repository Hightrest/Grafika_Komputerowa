using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CategoriesCrud
    {
        public DataTable GetAllCategoies()
        {
            var dt = new DataTable();
            string strConString = Configuration.ConnectionString;
            using (var con = new SqlConnection(strConString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT [CategoryID] ,[CategoryName] ,[Description] ,[Picture] FROM [Northwind].[dbo].[Categories]", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }
        public int InsertCategory(string categoryName, string description)
        {
            string strConString = Configuration.ConnectionString;
            using (SqlConnection con = new SqlConnection(@strConString))
            {
                con.Open();
                string query = "Insert into [Northwind].[dbo].[Categories] ([CategoryName], [Description]) values(@category_name, @description)";
                SqlCommand cmd = new SqlCommand(@query, con);
                cmd.Parameters.AddWithValue("@category_name", categoryName);
                cmd.Parameters.AddWithValue("@description", description);
                return cmd.ExecuteNonQuery();
            }
        }
        public int RemoveCategory(int categoryID)
        {
            string strConString = Configuration.ConnectionString;
            using (SqlConnection con = new SqlConnection(@strConString))
            {
                con.Open();
                string query = "Delete From [Northwind].[dbo].[Categories] Where ([CategoryID]=@category_id)";
                SqlCommand cmd = new SqlCommand(@query, con);
                cmd.Parameters.AddWithValue("@category_id", categoryID);
                return cmd.ExecuteNonQuery();
            }
        }

        public int UpdateCategory(int categoryID, string categoryName, string description)
        {
            string strConString = Configuration.ConnectionString;
            using (SqlConnection con = new SqlConnection(@strConString))
            {
                con.Open();
                string query = "Update [Northwind].[dbo].[Categories] Set [CategoryName]=@category_name, [Description]=@description Where [CategoryID]=@category_id";
                SqlCommand cmd = new SqlCommand(@query, con);
                cmd.Parameters.AddWithValue("@category_id", categoryID);
                cmd.Parameters.AddWithValue("@category_name", categoryName);
                cmd.Parameters.AddWithValue("@description", description);
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
