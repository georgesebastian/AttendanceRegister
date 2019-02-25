using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AttendanceRegisterService
{
    public class DataAccess
    {

        string connectionString = @"Data Source=DJG;Initial Catalog=AttendanceRegisterDB;User ID=George;Password=qwerty123";
        public List<Ward> GetWards()
        {

            List<Ward> wardsList = new List<Ward>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM WARDS", connection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Ward ward = new Ward();
                        ward.WardId = Convert.ToInt32(reader["Id"]);
                        wardsList.Add(ward);
                    }
                }
            }

            return wardsList;
        }

        internal void InsertWard(Ward ward)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Wards (WardName, CreatedBy, CreatedDate, UpdatedBy, UpdatedDate) VALUES " +
                    "                                 ('St. George Ward', 'George', '2019-02-24','George', '2019-02-24');", 
                                                      connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        internal void InsertParishioner(Parishioner parishioner)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO parishioners VALUES", connection))
                {
                    cmd.ExecuteNonQuery();
                }

            }
        }

    }
}