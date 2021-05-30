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
    public partial class ChangePlayer : Form
    {
        public ChangePlayer()
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

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void ChangePlayer_Load(object sender, EventArgs e)
        {

        }
        public SqlConnection sqlcon = new SqlConnection(@"Data Source=LAPTOP-8RIM0556\SQLEXPRESS;Initial Catalog=Tennis;Integrated Security=True");

        private void Button1_Click(object sender, EventArgs e)
        {
            lblAge.Visible = true;
            lblCountry.Visible = true;
            lblHand.Visible = true;
            lblID.Visible = true;
            lblRating.Visible = true;
            lblSurname.Visible = true;
            txtAge.Visible = true;
            txtRating.Visible = true;
            txtSurname.Visible = true;
            cmbCountry.Visible = true;
            cmbHand.Visible = true;
            btnAdd.Visible = true;
            sqlcon.Open();
            string query = @"Select Surname,Country,Age,Rating,Hand from TennisPlayers where ID_TennisPlayers='"+txtId.Text+"'";

            SqlCommand com = new SqlCommand(query, sqlcon);
            SqlDataReader reader = com.ExecuteReader();

            List<string> data = new List<string>();
            while (reader.Read())
            {
                txtAge.Text = reader[2].ToString();
                txtRating.Text = reader[3].ToString();
                txtSurname.Text = reader[0].ToString();
                cmbCountry.Text = reader[1].ToString();
                cmbHand.Text = reader[4].ToString();
            }
            reader.Close();
            sqlcon.Close();

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            sqlcon.Open();
            string query = @"update TennisPlayers set  Surname='"+txtSurname.Text+"'," +
            "Country='"+cmbCountry.Text+"',Age='"+txtAge.Text+"',Rating='"+txtRating.Text+
            "',Hand='"+cmbHand.Text+"' where ID_TennisPlayers='" + txtId.Text + "'";

            SqlCommand com = new SqlCommand(query, sqlcon);
            SqlDataReader reader = com.ExecuteReader();
            reader.Close();
            sqlcon.Close();
        }
    }
}
