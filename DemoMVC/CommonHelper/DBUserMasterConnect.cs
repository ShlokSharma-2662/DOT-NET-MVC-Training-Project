using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DemoMVC.CommonHelper
{
    public class DBUserMasterConnect
    {
        SqlConnection con = null;
        SqlCommand cmd = null;

        public DBUserMasterConnect()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBconnection"].ConnectionString);
            con.Open();
        }

        public int InsertRecord(InsertRecord IR)
        {
            if (IR.Id == 0)
            {
                using (con)
                {
                    cmd = new SqlCommand("CreateNewAccount_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = IR.Id;
                    cmd.Parameters.AddWithValue("@CreatedAt", SqlDbType.VarChar).Value = DateTime.Now.ToString("dd/MM/yyyy | hh:mm:ss tt");
                    cmd.Parameters.AddWithValue("@EditedAt", SqlDbType.VarChar).Value = null;
                    cmd.Parameters.AddWithValue("@DeletedAt", SqlDbType.VarChar).Value = null;
                    cmd.Parameters.AddWithValue("@FirstName", SqlDbType.VarChar).Value = IR.FirstName;
                    cmd.Parameters.AddWithValue("@LastName", SqlDbType.VarChar).Value = IR.LastName;
                    cmd.Parameters.AddWithValue("@ContactNo", SqlDbType.VarChar).Value = IR.ContactNo;
                    cmd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = IR.Email;
                    cmd.Parameters.AddWithValue("@Password", SqlDbType.VarChar).Value = IR.Password;
                    cmd.Parameters.AddWithValue("@Gender", SqlDbType.Char).Value = IR.Gender;
                    cmd.Parameters.AddWithValue("@Status", SqlDbType.Char).Value = IR.Status;
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            else
            {
                using (con)
                {
                    cmd = new SqlCommand("CreateNewAccount_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = IR.Id;
                    cmd.Parameters.AddWithValue("@CreatedAt", SqlDbType.VarChar).Value = null;
                    cmd.Parameters.AddWithValue("@EditedAt", SqlDbType.VarChar).Value = DateTime.Now.ToString("dd/MM/yyyy | hh:mm:ss tt");
                    cmd.Parameters.AddWithValue("@DeletedAt", SqlDbType.VarChar).Value = null;
                    cmd.Parameters.AddWithValue("@FirstName", SqlDbType.VarChar).Value = IR.FirstName;
                    cmd.Parameters.AddWithValue("@LastName", SqlDbType.VarChar).Value = IR.LastName;
                    cmd.Parameters.AddWithValue("@ContactNo", SqlDbType.VarChar).Value = IR.ContactNo;
                    cmd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = IR.Email;
                    cmd.Parameters.AddWithValue("@Password", SqlDbType.VarChar).Value = IR.Password;
                    cmd.Parameters.AddWithValue("@Gender", SqlDbType.Char).Value = IR.Gender;
                    cmd.Parameters.AddWithValue("@Status", SqlDbType.Char).Value = IR.Status;
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            return 1;
        }

         public List<UserChartResponseModel> GetUserChartData(string SelectAsLabel, string GroupBy)
        {
            List<UserChartResponseModel> ULst = new List<UserChartResponseModel>();
            using (con)
            {
                cmd = new SqlCommand("GetUserRecordsChart_SP", con);
                cmd.Parameters.AddWithValue("@SelectAsLabel", SqlDbType.VarChar).Value = SelectAsLabel;
                cmd.Parameters.AddWithValue("@GroupBy", SqlDbType.VarChar).Value = GroupBy;
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    UserChartResponseModel U = new UserChartResponseModel();
                    U.setLabel(Convert.ToString(rdr["label"]));
                    U.setValue(Convert.ToInt32(rdr["value"]));
                    ULst.Add(U);
                }
            }
            return ULst;
        }

        public List<InsertRecord> GetUserData(string OrderBy, string WhereClause)
        {
            List<InsertRecord> Rlst = new List<InsertRecord>();
            using (con)
            {
                cmd = new SqlCommand("GetUserRecords", con);
                cmd.Parameters.AddWithValue("@OrderBy", SqlDbType.VarChar).Value = OrderBy;
                cmd.Parameters.AddWithValue("@WhereClause", SqlDbType.VarChar).Value = WhereClause;
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    InsertRecord IR = new InsertRecord();
                    IR.setId(Convert.ToInt32(reader["Id"]));
                    IR.setFirstName(Convert.ToString(reader["FirstName"]));
                    IR.setLastName(Convert.ToString(reader["LastName"]));
                    IR.setEmail(Convert.ToString(reader["EmailId"]));
                    IR.setContactNo(Convert.ToString(reader["ContactNo"]));
                    IR.setGender(Convert.ToChar(reader["Gender"]));
                    IR.setStatus(Convert.ToChar(reader["Status"]));
                    IR.setCreatedAt(Convert.ToString(reader["CreatedAt"]));
                    IR.setEditedAt(Convert.ToString(reader["EditedAt"]));
                    IR.setDeletedAt(Convert.ToString(reader["DeletedAt"]));
                    Rlst.Add(IR);
                }
            }
            return Rlst;
        }

        public int UpdateUserStatus(InsertRecord IR)
        {
            if (IR.Id != 0)
            {
                using (con)
                {
                    cmd = new SqlCommand("UpdateUserStatus_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = IR.Id;
                    cmd.Parameters.AddWithValue("@DeletedAt", SqlDbType.VarChar).Value = DateTime.Now.ToString("dd/MM/yyyy | hh:mm:ss tt");
                    cmd.Parameters.AddWithValue("@Status", SqlDbType.Char).Value = IR.Status;
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            return 1;
        }

    }
}