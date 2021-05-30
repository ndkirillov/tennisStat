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
    public partial class AddPlayer : Form
    {
        public AddPlayer()
        {
            InitializeComponent();
            sqlcon.Open();
            string query = @"Select Country_Name from Country";

            SqlCommand com = new SqlCommand(query, sqlcon);
            SqlDataReader reader = com.ExecuteReader();

            List<string> data = new List<string>();
            while (reader.Read())
            {
                data.Add(reader[0].ToString());
            }
            reader.Close();
            sqlcon.Close();
            foreach (string s in data)
            cmbCountry.Items.Add(s);
            
        }
        public SqlConnection sqlcon = new SqlConnection(@"Data Source=LAPTOP-8RIM0556\SQLEXPRESS;Initial Catalog=Tennis;Integrated Security=True");

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            if (txtAge.Text != "" && txtRating.Text != "" && txtSurname.Text != "" && cmbCountry.Text != "" && cmbHand.Text != "" )
            {
                sqlcon.Open();
                string query = @"insert into TennisPlayers (Surname,Country,Age,Rating,Hand) 
values ('"+txtSurname.Text+"','"+cmbCountry.Text+"','" +txtAge.Text+"','"+txtRating.Text+"','"+cmbHand.Text+ "')";

                SqlCommand com = new SqlCommand(query, sqlcon);
                SqlDataReader reader = com.ExecuteReader();

                reader.Close();
                sqlcon.Close();
            }
        }
    }
}
