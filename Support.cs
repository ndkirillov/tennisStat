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
    public partial class Support : Form
    {
        public Support()
        {
            InitializeComponent();
        }
        public SqlConnection sqlcon = new SqlConnection(@"Data Source=LAPTOP-8RIM0556\SQLEXPRESS;Initial Catalog=Tennis;Integrated Security=True");
        public string email = "";
        private void Button1_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            string query = @"Select Email_Profile from Person_Profile where ID_Person ='"+ForAnalitics.ID+"'";

            SqlCommand com = new SqlCommand(query, sqlcon);
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read()) email = reader[0].ToString();
            reader.Close();
            sqlcon.Close();
            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress("anastasiapetrunina@mail.ru", "Statistics");
            // кому отправляем

            MailAddress to = new MailAddress(email);
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            // тема письма
            m.Subject = "Кажется, вы забыли пароль!";
            // текст письма
            m.Body = textBox1.Text;
            // письмо представляет код html
            m.IsBodyHtml = true;
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.mail.ru", 587);
            // логин и пароль
            smtp.Credentials = new NetworkCredential("anastasiapetrunina@mail.ru", "Nikita13062000");
            smtp.EnableSsl = true;
            smtp.Send(m);
        }

        private void Support_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
