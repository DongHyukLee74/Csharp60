using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Ex0643
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString;

            using (SqlConnection sqlCon = new SqlConnection())
            {
                sqlCon.ConnectionString = connectionString;

                // DB에 연결하고,
                sqlCon.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlCon;
                cmd.CommandText = "SELECT * FROM MemberInfo";

                SqlDataReader reader = cmd.ExecuteReader();

                // ......[reader를 이용해 레코드를 하나씩 조회]......
            }
        }
    }
}
