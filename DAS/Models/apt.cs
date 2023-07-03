using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DAS.Models
{
    public class apt
    {
        public string name { get; set;  }
        public string surname { get; set; }
        public string email { get; set; }
        public string phoneno { get; set; }
    
        [DataType(DataType.Date)]
        public DateTime? adate { get; set; }
        public string message { get; set; }


        int rowEffected;
        string dbConnection = @"data source=;initial catalog=das;integrated security=True";

        public int Insert(apt a)
        {

            SqlConnection con = new SqlConnection(dbConnection);
            con.Open();
            string query = "INSERT INTO dbo.appt (Name,Surname,Email,PhoneNo,Message,adate) VALUES('" + a.name + "','" + a.surname + "','" + a.email+ "','" + a.phoneno + "','" + a.message + "','" + a.adate + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            rowEffected = cmd.ExecuteNonQuery();
            con.Close();
            return rowEffected;
        }
    }
}