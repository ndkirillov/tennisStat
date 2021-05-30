using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursov
{
    public partial class DeletePerson : Form
    {
        public DeletePerson()
        {
            InitializeComponent();
        }
        public SqlConnection sqlcon = new SqlConnection(@"Data Source=LAPTOP-8RIM0556\SQLEXPRESS;Initial Catalog=Tennis;Integrated Security=True");
        public string email = "";
        private void Button1_Click(object sender, EventArgs e)
        {

            sqlcon.Open();
            string query = @"select Email_Profile from Person_Profile where ID_Person='" + txtId.Text + "'";

            SqlCommand com = new SqlCommand(query, sqlcon);
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read()) email = reader[0].ToString();
            reader.Close();
            query = @"delete from Person_Profile where ID_Person='" + txtId.Text + "'";

            com = new SqlCommand(query, sqlcon);
            reader = com.ExecuteReader();
            reader.Close();
            query = @"delete from Passwords where Email='" + email + "'";

            com = new SqlCommand(query, sqlcon);
            reader = com.ExecuteReader();
            reader.Close();
            
           
            sqlcon.Close();
           
        }
    }
}
