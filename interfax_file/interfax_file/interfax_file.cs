using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace interfax_file
{
    public class interfax_file
    {
        public static SqlConnection
               GetDBConnection()//asdfsdaf
        {
            string connString; 
            connString = Properties.Settings.Default.interfax_fileConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
        public  List<string[]> if_read(){
            try
            {
                List<string[]> templist = new List<string[]>();
                SqlConnection s = GetDBConnection();
                SqlCommand myCommand = new SqlCommand("select * from interfax_file", s);
                using (SqlDataReader myreader = myCommand.ExecuteReader())
                {
                    while (myreader.Read())
                    {
                        templist.Add(new string[] {  myreader["date"].ToString(), myreader["memory"].ToString() });
                    }
                }
                return templist;
            }
            catch (Exception)
            {
                List<string[]> templist=new List<string[]>();
                templist.Add(new string[] {  "error", "error" });
                return templist; 
            }
        }
        public  bool if_write(string date,string memory) {
            try
            {
                SqlConnection sqlConnection1 = GetDBConnection();
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT interfax_file (date, memory) VALUES ('"+date.ToString()+"', '"+memory.ToString()+"');";
                cmd.Connection = sqlConnection1;
                sqlConnection1.Open();
                cmd.ExecuteNonQuery();
                sqlConnection1.Close();
                return true;    
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
