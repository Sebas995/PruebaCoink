using Coink.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Coink.DAL
{
    /// <summary>
    /// Administration of users
    /// </summary>
    public class UserDAL
    {
        #region Globals
        private readonly string ConnCoink = ConfigurationManager.ConnectionStrings["ConnCoink"].ToString();
        #endregion

        #region Methods
        /// <summary>
        /// Get User By Id
        /// </summary>
        /// <param name="IdUser"></param>
        /// <returns></returns>
        public UserRes GetUserById(int IdUser)
        {
            UserRes User = null;

            using (SqlConnection cnx = new SqlConnection(ConnCoink))
            {
                cnx.Open();
                using (SqlCommand cmd = new SqlCommand("GetUsers", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdUser", IdUser);
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        User = new UserRes
                        {
                            IdUser = Convert.ToInt32(rdr["IdUser"]),
                            Name = Convert.ToString(rdr["Name"]),
                            LastName = Convert.ToString(rdr["LastName"]),
                            Phone = Convert.ToInt32(rdr["Phone"]),
                            Address = Convert.ToString(rdr["Address"]),
                            NameCity = Convert.ToString(rdr["NameCity"]),
                            NameDepartment = Convert.ToString(rdr["NameDepartment"]),
                            NameCountry = Convert.ToString(rdr["NameCountry"]),
                        };
                    }
                    rdr.Close();
                }
                cnx.Close();
            }

            return User;
        }

        /// <summary>
        /// Get all users register
        /// </summary>
        /// <returns>All Users</returns>
        public List<UserRes> GetUsers()
        {
            List<UserRes> Users = new List<UserRes>();

            using (SqlConnection cnx = new SqlConnection(ConnCoink))
            {
                cnx.Open();
                using (SqlCommand cmd = new SqlCommand("GetUsers", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdUser", 0);
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        Users.Add(new UserRes 
                        {
                            IdUser = Convert.ToInt32(rdr["IdUser"]),
                            Name = Convert.ToString(rdr["Name"]),
                            LastName = Convert.ToString(rdr["LastName"]),
                            Phone = Convert.ToInt32(rdr["Phone"]),
                            Address = Convert.ToString(rdr["Address"]),
                            NameCity = Convert.ToString(rdr["NameCity"]),
                            NameDepartment = Convert.ToString(rdr["NameDepartment"]),
                            NameCountry = Convert.ToString(rdr["NameCountry"]),
                        });
                    }
                    rdr.Close();
                }
                cnx.Close();
            }

            return Users;
        }

        /// <summary>
        /// Create Users
        /// </summary>
        /// <param name="User"></param>
        public void CreateUser(UserReq User)
        {
            using (SqlConnection cnx = new SqlConnection(ConnCoink))
            {
                cnx.Open();
                using (SqlCommand cmd = new SqlCommand("InsertUsers", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", User.Name);
                    cmd.Parameters.AddWithValue("@LastName", User.LastName);
                    cmd.Parameters.AddWithValue("@Phone", User.Phone);
                    cmd.Parameters.AddWithValue("@Address", User.Address);
                    cmd.Parameters.AddWithValue("@IdCity", User.IdCity);
                    cmd.ExecuteReader();
                }
                cnx.Close();
            }
        }
        #endregion
    }
}
