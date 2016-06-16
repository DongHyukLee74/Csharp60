using System;
using System.Data;
//using Ex0654;
//using Ex0654.TestDBDataSetTableAdapters;
using System.Configuration;
using System.Data.SqlClient;

namespace Ex0654
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 547
            /*
            TestDBDataSet ds = new TestDBDataSet();
            MemberInfoTableAdapter da = new MemberInfoTableAdapter();

            // 새로운 레코드를 삽입: INSERT
            da.Insert("Julie", new DateTime(1985, 5, 6), "julie@naver.com", 1);

            // 테이블의 모든 레코드를 조회: SELECT
            da.Fill(ds.MemberInfo);

            foreach (TestDBDataSet.MemberInfoRow row in ds.MemberInfo)
            {
                Console.WriteLine(string.Format("{0}, {1}, {2}, {3}", row.Name, row.Birth, row.Email, row.Family));
            }

            // 테이블의 특정 레코드의 값을 변경: UPDATE
            TestDBDataSet.MemberInfoRow[] rows = ds.MemberInfo.Select("Name = 'julie'") as TestDBDataSet.MemberInfoRow[];

            rows[0].Name = "July";
            da.Update(rows[0]);

            // 테이블의 특정 레코드를 삭제: DELETE
            da.Delete(rows[0].Name, rows[0].Birth, rows[0].Email, rows[0].Family);*/
            #endregion 547
            string connectionString = ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString;

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                using (SqlTransaction transaction = sqlCon.BeginTransaction())
                {
                    // SqlCommand를 이용해 쿼리 수행
                    transaction.Commit();
                }
            }
        }
    }
}
