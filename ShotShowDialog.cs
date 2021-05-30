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
    public partial class ShotShowDialog : Form
    {
        public ShotShowDialog()
        {
            InitializeComponent();
            idShot = ForAnalitics.shotid;
            sqlcon.Open();
            string query = @"Select Type, Speed, Spin_Rate from Shot where ID_Shot='"+idShot+"'";

            SqlCommand com = new SqlCommand(query, sqlcon);
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                lblPutType.Text = reader[0].ToString();
                lblPutSpeed.Text = reader[1].ToString();
                lblPutRate.Text = reader[2].ToString();
            }
            reader.Close();
            sqlcon.Close();

        }
        public int idShot = 0;
        public SqlConnection sqlcon = new SqlConnection(@"Data Source=LAPTOP-8RIM0556\SQLEXPRESS;Initial Catalog=Tennis;Integrated Security=True");

        private void LblSpeedRate_Click(object sender, EventArgs e)
        {

        }
    }
}
