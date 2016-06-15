using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Ex0646
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString;

            DataSet ds = new DataSet();
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM MemberInfo", sqlCon);
                sda.Fill(ds, "MemberInfo");
            }

            ds.WriteXml(Console.Out);   // DataSet이 가진 내용을 콘솔 화면에 출력한다.
        }
    }
}
