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
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
            LoadData();
        }
       public  SqlConnection sqlcon = new SqlConnection(@"Data Source=LAPTOP-8RIM0556\SQLEXPRESS;Initial Catalog=Tennis;Integrated Security=True");

        public void LoadData()
        {
           
            sqlcon.Open();
            string query = @"Select Tournament.Name_Tournament,Country.Country_Name ,Tournament.Date_Start,Tournament.Date_Finish 
from Tournament inner join Start_Table on Tournament.ID_Tournament=Start_Table.Tournament_info
inner join Country on Tournament.Country_info=Country.ID_Country";
            
            SqlCommand com = new SqlCommand(query, sqlcon);
            SqlDataReader reader = com.ExecuteReader();

            List<string[]> data = new List<string[]> ();
            while (reader.Read())
            {
                data.Add(new string[3]);
                data[data.Count - 1][0] = reader[0].ToString();//Tournament Name
                data[data.Count - 1][1] = reader[1].ToString();//Tournament Country
                data[data.Count - 1][2] = reader[2].ToString().Substring(0,10)+"-" + reader[3].ToString().Substring(0,10);//Tournament Date
           
            }
            int x = 0;
            foreach (string[]c in data)
            {
                Start_Table.RowCount += 1;
                Start_Table[0, x].Value = c[0];
                Start_Table[1, x].Value = c[1];
                Start_Table[2, x].Value = c[2];
                x++;
            }
            reader.Close();
            sqlcon.Close();
        }
        public string dateTournStart = "";
        public string dateTournFinish = "";
        public int idTourn = 0;
        private void Start_Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //string valuejj = Start_Table.CurrentCell.Value.ToString();
            sqlcon.Open();
            int col = Start_Table.CurrentCell.ColumnIndex;
            int row = Start_Table.CurrentCell.RowIndex;
           if (col == 0)
            {
                dateTournStart = Start_Table[col + 2, row].Value.ToString().Substring(0,10);
                dateTournFinish = Start_Table[col + 2, row].Value.ToString().Substring(11);

                
                string query = @"Select ID_Tournament from Tournament where Name_Tournament = '" + Start_Table.CurrentCell.Value.ToString() +
                "'and Date_Start = '" + dateTournStart + "'and  Date_Finish= '" + dateTournFinish + "'";

                SqlCommand com = new SqlCommand(query, sqlcon);
                SqlDataReader reader = com.ExecuteReader();
                while(reader.Read())
                idTourn = (int)reader[0];
                reader.Close();

                List<string[]> description = new List<string[]>();
                List<int> idMatch = new List<int>();
                query = @"Select Match_Stage, Match_Score, ID_Match from Match where
                 ID_Tournament = '" + idTourn + "'";
                com = new SqlCommand(query, sqlcon);
               reader = com.ExecuteReader();
                while (reader.Read())
                {
                    description.Add(new string[2]);
                    description[description.Count - 1][0] = reader[0].ToString();//Match Stage
                    description[description.Count - 1][1] = reader[1].ToString();//Match Score
                    //description[description.Count - 1][2] = reader[2].ToString() + "-" + reader[3].ToString();//Tennis Players
                    idMatch.Add((int)reader[2]);
                }
                reader.Close();
                int x = 0;
                foreach (string[] c in description)
                {
                    Matches.RowCount += 1;
                    Matches[0, x].Value = c[0];
                    Matches[1, x].Value = c[1];
                   // Matches[2, x].Value = c[2];
                    x++;
                  
                }
                x = 0;
                foreach(int c in idMatch)
                {
                    string check = "";
                    query = @"Select TennisPlayers.Surname from TennisPlayers
inner join Match_Tennis_Player on TennisPlayers.ID_TennisPlayers = Match_Tennis_Player.ID_Player 
where Match_Tennis_Player.ID_Match ='"+c+"'";
                    com = new SqlCommand(query, sqlcon);
                    reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                       check += reader[0].ToString()+" ";
                    }
                    reader.Close();
                   Matches[2, x].Value = check;
                    x++;
                }
                sqlcon.Close();
            }


        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
    }

