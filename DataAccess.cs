using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryMaker
{
    public class DataAccess : IDisposable
    {

        SqlConnection con;
        SqlCommand command;
        SqlCommand command1;
        public DataAccess()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DiaryDatabase"].ConnectionString);
            this.con.Open();
        }
        public int AddUser(params string[] inputs)
        {
            string sql = "INSERT INTO WRITERS(Username,Password) VALUES('" + inputs[0] + "','" + inputs[1] + "')";
            command = new SqlCommand(sql, con);
            return command.ExecuteNonQuery();
        }
        public int AddEvent(params string[] inputs)
        {

            string sql = "INSERT INTO Documents(EventFile,EventImportance,EventDate,EventPic,UserId) VALUES('" + inputs[0] + "','" + inputs[1] + "','" + inputs[2] + "','" + inputs[3] + "','" + int.Parse(inputs[4]) + "')";
            command = new SqlCommand(sql, con);
            return command.ExecuteNonQuery();
        }
        public int UpdateEvent(params string[] inputs)
        {
            int EventNo = int.Parse(inputs[4]);
            string sql = "UPDATE Documents SET EventFile='" + inputs[0] + "',EventPic='" + inputs[3] + "',EventDate='" + inputs[2] + "',EventImportance='" + inputs[1] + " ' WHERE EventNo=" + EventNo ;
            command = new SqlCommand(sql, con);
            return command.ExecuteNonQuery();
            
        }
        
        public void Dispose()
        {
            con.Close();
        }
        public SqlDataReader GetPassword(int UserId)
        {
            string sql = "SELECT Password FROM WRITERS WHERE UserId = '" + UserId + "'";
            command = new SqlCommand(sql, con);
            return command.ExecuteReader();

        }
       
        public int DeleteDocuments(int id)
        {
            string sql = "Delete from Documents Where EventNo =" + id;
            command = new SqlCommand(sql, con);
            return command.ExecuteNonQuery();

        }
        public SqlDataReader GetEvents(string sql)
        {

            command = new SqlCommand(sql, con);
            return command.ExecuteReader();

        }
        public int ExecuteQuery(string sql)
        {
            command = new SqlCommand(sql, con);
            return command.ExecuteNonQuery();
        }
        public SqlDataReader Search(string sql)
        {
            return (new SqlCommand(sql, con)).ExecuteReader();
        }

    }
}
