﻿using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;

namespace Ex0655
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 550
            /*
            string connectionString = ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString;

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();

                using (SqlTransaction transaction = sqlCon.BeginTransaction())
                {
                    string txt = "INSERT INTO MemberInfo (Name, Birth, Email, Family) VALUES ('{0}', '{1}', '{2}', {3})";

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlCon;
                    cmd.Transaction = transaction;
                    cmd.CommandText = string.Format(txt, "Fox", "1970-01-25", "fox@gmail.com", "5");
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = string.Format(txt, "Dana", "1972-01-25", "fox@gmail.com", "1");
                    cmd.ExecuteNonQuery();  // PK 중복으로 예외 발생
                    transaction.Commit();
                }
            }*/
            #endregion 550
            string connectionString = ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString;

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            using (TransactionScope tx = new TransactionScope())
            {
                sqlCon.Open();
                string txt = "INSERT INTO MemberInfo (Name, Birth, Email, Family) VALUES ('{0}', '{1}', '{2}', {3})";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlCon;
                cmd.CommandText = string.Format(txt, "Fox", "1970-01-25", "fox@gmail.com", "5");
                cmd.ExecuteNonQuery();
                cmd.CommandText = string.Format(txt, "Dana", "1972-01-25", "fox@gmail.com", "1");
                cmd.ExecuteNonQuery();

                tx.Complete();
            }
        }
    }
}
