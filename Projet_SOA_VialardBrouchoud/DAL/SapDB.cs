using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SapDB:ISapDB
    {
        string ConnectionString { get; }
        public SapDB()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["database"].ConnectionString;
        }
		/// <summary>
		/// Permet de connaître la correspondance d'un cardId pour un username
		/// </summary>
		/// <param name="cardId"></param>
		/// <returns>Retourn null si le cardId n'existe pas.</returns>
        public string GetUsernameByCardId(string cardId)
        {
			string result = null;

			try
			{
				using (SqlConnection cn = new SqlConnection(ConnectionString))
				{
					string query = @"SELECT Username FROM SAP
							WHERE CardId = @cardId";
					SqlCommand cmd = new SqlCommand(query, cn);
					cmd.Parameters.AddWithValue("@cardId", cardId);
					cn.Open();

					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						if (dr.Read())
						{
							result = dr["Username"].ToString();
						}
					}
				}
			}
			catch (Exception e)
			{
				throw e;
			}

			return result;
		}

        public bool CreateUser(string username, string cardId)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(ConnectionString))
                {
                    string query = @"INSERT INTO SAP (Username, CardId) 
                            values (@username, @cardId)";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@cardId", cardId);
                    cmd.Parameters.AddWithValue("@username", username);
                    cn.Open();
                    return cmd.ExecuteNonQuery() >= 1;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return false;
        }

        public bool RemoveQuota(string username, int quota)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(ConnectionString))
                {
                    string query = @"UPDATE SAP 
                                       SET Quota = Quota - @QuotaToRemove
                                       FROM SAP
                                       WHERE Username = @Username";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("Username", username);
                    cmd.Parameters.AddWithValue("QuotaToRemove", quota);

                    cn.Open();

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool AddQuota(string username, int quota)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(ConnectionString))
                {
                    string query = @"UPDATE SAP 
                                       SET Quota = Quota + @QuotaToAdd
                                       FROM SAP
                                       WHERE Username = @Username";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("Username", username);
                    cmd.Parameters.AddWithValue("QuotaToAdd", quota);

                    cn.Open();

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
