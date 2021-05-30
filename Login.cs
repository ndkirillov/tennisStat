using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursov
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void JTextBox1_Load(object sender, EventArgs e)
        {

        }
        public static int ID = 0;
       public  SqlConnection sqlcon = new SqlConnection(@"Data Source=LAPTOP-8RIM0556\SQLEXPRESS;Initial Catalog=Tennis;Integrated Security=True");

        private void Btn_login_Click(object sender, EventArgs e)
        {
 
            sqlcon.Open();
            string query = "Select Person_Profile.ID_Person from Person_Profile inner join Passwords on Person_Profile.Email_Profile=Passwords.Email Where Passwords.Email ='" + jTextbox_Email.TextValue + "'and Passwords.Password = '" + jTextbox_Password.TextValue + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            SqlCommand com = new SqlCommand(query, sqlcon);
            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            { ID = (int)reader[0]; }

            reader.Close();
            sqlcon.Close();
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                ForAnalitics cs = new ForAnalitics();
                cs.Show();
            }
        }

        private void LblForget_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            string query = "Select Password from Passwords Where Email ='" + jTextbox_Email.Text.Trim() + "'";

            SqlCommand com = new SqlCommand(query, sqlcon);
            SqlDataReader reader = com.ExecuteReader();

            string password = "";
            while (reader.Read())
            { password = reader[0].ToString(); }

            reader.Close();
            sqlcon.Close();
            if (password != "")
            {
                // отправитель - устанавливаем адрес и отображаемое в письме имя
                MailAddress from = new MailAddress("anastasiapetrunina@mail.ru", "Your Fitness-club");
                // кому отправляем

                MailAddress to = new MailAddress(jTextbox_Email.Text);
                // создаем объект сообщения
                MailMessage m = new MailMessage(from, to);
                // тема письма
                m.Subject = "Кажется, вы забыли пароль!";
                // текст письма
                m.Body = "Ваш пароль для входа в фитнес-клуб: " + password;
                // письмо представляет код html
                m.IsBodyHtml = true;
                // адрес smtp-сервера и порт, с которого будем отправлять письмо
                SmtpClient smtp = new SmtpClient("smtp.mail.ru", 587);
                // логин и пароль
                smtp.Credentials = new NetworkCredential("anastasiapetrunina@mail.ru", "Nikita13062000");
                smtp.EnableSsl = true;
                smtp.Send(m);
            }
            else
            {
                MessageBox.Show("Проверьте правильность почты и попробуйте еще раз");
                jTextbox_Email.Text = "";
            }
        }
    }
}
