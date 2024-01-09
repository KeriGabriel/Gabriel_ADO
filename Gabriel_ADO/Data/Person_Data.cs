using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Gabriel_ADO.Models;

namespace Gabriel_ADO.Data
{
    public class Person_Data
    {
        string conString = ConfigurationManager.ConnectionStrings["dbConnection"].ToString();
        // get Master List
        public List<Person> GetMasterList() 
        {
            List<Person> Masterlist = new List<Person>();
                using(SqlConnection connection = new SqlConnection(conString)) 
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "MasterList";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable MasterDT = new DataTable();

                connection.Open();
                adapter.Fill(MasterDT);
                connection.Close();

                foreach(DataRow DR in MasterDT.Rows)
                {
                    Masterlist.Add(new Person
                    {
                        PersonID = Convert.ToInt32(DR["ID"]),
                        FirstName = DR["FirstName"].ToString(),
                        LastName = DR["LastName"].ToString()
                    }) ;
                }
            }
                return Masterlist;
        }
    }
}