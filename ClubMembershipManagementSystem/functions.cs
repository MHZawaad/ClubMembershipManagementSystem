using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMembershipManagementSystem
{



    class Functions
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private String Constr;


        public Functions()
        {
            Constr = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=C:\Users\mahdi\source\repos\ClubMembershipManagementSystem\ClubMembershipManagementSystem\MSSQLLocalDB\CMMS.mdf;Integrated Security=True;Connect Timeout=30;";
            Con = new SqlConnection(Constr);
            Cmd = new SqlCommand();
            Cmd.Connection = Con;


        }

        public DataTable GetData(String Query)
        {
            dt = new DataTable();
            sda = new SqlDataAdapter(Query, Constr);
            sda.Fill(dt);
            return dt;
        }

        public int SetData(String Query)
        {

            int cnt = 0;
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();

            }
            Cmd.CommandText = Query;
            cnt = Cmd.ExecuteNonQuery();
            return cnt;


        }

        
    }
}
