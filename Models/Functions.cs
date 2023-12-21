using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HopitalManagementSystem.Models
{
    public class Functions
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private DataTable dt;
        private string constr;
        private SqlDataAdapter sda;
        public Functions()
        {
            constr = @"Data Source =LAPTOP-QG62IU1U\SQLEXPRESS; Initial Catalog = ClinicMS; Integrated Security = True";
            con = new SqlConnection(constr);
            cmd = new SqlCommand();
            cmd.Connection = con;
        }

        public int SetDatas(string sql)
        {
            int cnt = 0;
            if (con.State == ConnectionState.Closed )
            {
                con.Open();
            }
            cmd.CommandText = sql;
            cnt = cmd.ExecuteNonQuery();
            con.Close();
            return cnt;
        }
        public DataTable GetDatas(String Query)
        {
            dt = new DataTable();
            sda = new SqlDataAdapter(Query, constr);
            sda.Fill(dt);
            return dt;
        }
    }
}