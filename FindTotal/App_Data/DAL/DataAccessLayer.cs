using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace FindTotal
{
    public class DataAccessLayer
    {
        string successMessage = "Value is successfully inserted";
        static string ConnectionString = WebConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
        SqlConnection sqlConnection = new SqlConnection(ConnectionString);
        
        public DataAccessLayer()
        {

            //sqlConnection.Open();

        }

        public string ToInsertValue(DataAccessObject objectDataAccess)
        {
            sqlConnection.Open();
            string query = "INSERT INTO NumberValues(z) VALUES(@Z)";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            try
            {
                cmd.Parameters.AddWithValue("@Z", objectDataAccess.ValueOfZ);
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Dispose();
                sqlConnection.Close();
            }
            return successMessage;
        }

        public int GetXTotal()
        {
            sqlConnection.Open();
            string query = "SELECT SUM(x) FROM NumberValues";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            try
            {
                int totalXValue = (int)cmd.ExecuteScalar();
                sqlConnection.Close();
                return totalXValue;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetYTotal()
        {
            sqlConnection.Open();
            string query = "SELECT SUM(y) FROM NumberValues";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            try
            {
                int totalYValue = (int)cmd.ExecuteScalar();
                sqlConnection.Close();
                return totalYValue;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetZTotal()
        {
            sqlConnection.Open();
            string query = "SELECT SUM(z) FROM NumberValues";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            try
            {
                int totalZValue = (int)cmd.ExecuteScalar();
                sqlConnection.Close();
                return totalZValue;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}