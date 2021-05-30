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
    public partial class Registrationcs : Form
    {
        public Registrationcs()
        {
            InitializeComponent();
        }
        public SqlConnection sqlcon = new SqlConnection(@"Data Source=LAPTOP-8RIM0556\SQLEXPRESS;Initial Catalog=Tennis;Integrated Security=True");

        private void Button1_Click(object sender, EventArgs e)
        {
  
            if (txtEmail.Text != "" && txtEmail.Text != "" && txtPassword.Text != "" && txtSurname.Text != "")
            {
                sqlcon.Open();
                string query = @"insert into Passwords (Password,Email) values ('"+txtPassword.Text+"','"+txtEmail.Text+"')";
                SqlCommand com = new SqlCommand(query, sqlcon);
                SqlDataReader reader = com.ExecuteReader();
                reader.Close();

                query = @"insert into Person_Profile (Surname_Profile, Name_Profile, Email_Profile) values ('" + txtSurname.Text+ "','" + txtName.Text + "','" + txtEmail.Text + "')";
                com = new SqlCommand(query, sqlcon);
                reader = com.ExecuteReader();
                reader.Close();
            }
            else MessageBox.Show("Please fill all filds!");
        }

        private void LblRegistration_Click(object sender, EventArgs e)
        {

        }
    }
}
