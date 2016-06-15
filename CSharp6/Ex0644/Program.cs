using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Ex0644
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 523
            /*
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

                while (reader.Read())   // 읽어야 할 데이터가 남아 있다면 true, 없다면 false를 반환
                {
                    string name = reader.GetString(0);
                    DateTime birth = reader.GetDateTime(1);
                    string email = reader.GetString(2);
                    byte family = reader.GetByte(3);
                    Console.WriteLine("{0}, {1}, {2}, {3}", name, birth, email, family);
                }

                reader.Close();
            }*/
            #endregion 523
            string connectionString = ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString;

            // 아래의 변수 4개는 사용자로부터 값을 입력받은 것으로 가정
            string name = "Cooper";
            DateTime birth = new DateTime(1990, 2, 7);
            string email = "cooper@gmail.com";
            int family = 5;

            using (SqlConnection sqlCon = new SqlConnection())
            {
                sqlCon.ConnectionString = connectionString;
                sqlCon.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlCon;
                string text = string.Format("INSERT INTO MemberInfo(Name, Birth, Email, Family) VALUES('{0}', '{1}', '{2}', {3})", name, birth.ToShortDateString(), email, family);

                cmd.CommandText = text;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
