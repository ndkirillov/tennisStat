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
using System.Reflection;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;

namespace Kursov
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }
        public SqlConnection sqlcon = new SqlConnection(@"Data Source=LAPTOP-8RIM0556\SQLEXPRESS;Initial Catalog=Tennis;Integrated Security=True");

        private void LblChoose_Click(object sender, EventArgs e)
        {

        }
       public int variety = 0;
        private void BtnReportByShot_Click(object sender, EventArgs e)
        {

            txtFrom.Visible = true;
            txtTo.Visible = true;
            lblFrom.Visible = true;
            lblTo.Visible = true;
            lblFiltr.Visible = true;
            variety = 1;
            dataGridView1.ColumnCount = 2;
            dataGridView1.RowCount = 1;
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            btnGetData.Visible = true;
            chartTennisPlayers.Visible = false;
        }

        private void BtnGetData_Click(object sender, EventArgs e)
        {
            switch (variety)
            {
                case 1:
                    if (Convert.ToInt32(txtFrom.Text)<= Convert.ToInt32(txtTo.Text))
                    {
                        btnExport.Text = "Export to Excel";
                        dataGridView1.Visible = true;
                        sqlcon.Open();
                        //добавление необходимых колонок
                        DataGridViewTextBoxColumn dgvSpeed = new DataGridViewTextBoxColumn();
                        //установка свойств
                        dgvSpeed.Name = "Speed";
                        dgvSpeed.HeaderText = "Speed";
                        //добавили колонку
                        dataGridView1.Columns.Add(dgvSpeed);
                        DataGridViewTextBoxColumn dgvName = new DataGridViewTextBoxColumn();
                        //установка свойств
                        dgvName.Name = "Name";
                        dgvName.HeaderText = "Tennis Player";
                        //добавили колонку
                        dataGridView1.Columns.Add(dgvName);
                       
                        List<string[]> data = new List<string[]>();
                        string query = @"select Shot.Speed,TennisPlayers.Surname from Shot 
inner join Match_Progress on Shot.ID_Shot =  Match_Progress.Shot_id
inner join TennisPlayers on TennisPlayers.ID_TennisPlayers = Match_Progress.ID_Player 
where Shot.Speed>='"+txtFrom.Text+ "'and Shot.Speed<='"+txtTo.Text+"'";
                        SqlCommand com = new SqlCommand(query, sqlcon);
                        SqlDataReader reader = com.ExecuteReader();

                        while (reader.Read())
                        {
                            data.Add(new string[2]);
                            data[data.Count - 1][0] = reader[0].ToString();
                            data[data.Count - 1][1] = reader[1].ToString();
                        }
                        reader.Close();

                        int j = 0;
                        foreach (string[] s in data)
                        {
                            dataGridView1.RowCount += 1;
                            dataGridView1[0, j].Value = s[0];
                            dataGridView1[1, j].Value = s[1];
                            j++;
                        }
                        sqlcon.Close();
                    }
                    else
                    {
                        MessageBox.Show("Filter is not correct, try again");
                        txtFrom.Text = "";
                        txtTo.Text = "";
                    }
                    break;
                case 2: 
                    if (dtpStart.Value <= dtpFinish.Value)
                    {
                        btnExport.Text = "Export to Word";
                        dataGridView1.Visible = true;
                        sqlcon.Open();
                        //добавление необходимых колонок
                        DataGridViewTextBoxColumn dgvTournament = new DataGridViewTextBoxColumn();
                        //установка свойств
                        dgvTournament.Name = "Tournament";
                        dgvTournament.HeaderText = "Tournament";
                        //добавили колонку
                        dataGridView1.Columns.Add(dgvTournament);
                        DataGridViewTextBoxColumn dgvCountry= new DataGridViewTextBoxColumn();
                        //установка свойств
                        dgvCountry.Name = "Country";
                        dgvCountry.HeaderText = "Country";
                        //добавили колонку
                        dataGridView1.Columns.Add(dgvCountry);
                        DataGridViewTextBoxColumn dgvDate = new DataGridViewTextBoxColumn();
                        //установка свойств
                        dgvDate.Name = "Date";
                        dgvDate.HeaderText = "Date";
                        //добавили колонку
                        dataGridView1.Columns.Add(dgvDate);

                        List<string[]> data = new List<string[]>();
                        string query = @"select Tournament.Name_Tournament,Country.Country_Name, Tournament.Date_Start,Tournament.Date_Finish from Tournament
inner join Country on Country.ID_Country = Tournament.Country_info";
                        /*"'and Tournament.Date_Finish between '" + dtpStart.Value.ToShortDateString() + "'and '" + dtpFinish.Value.ToShortDateString() + */
                        //"'";
                        SqlCommand com = new SqlCommand(query, sqlcon);
                        SqlDataReader reader = com.ExecuteReader();

                        while (reader.Read())
                        {
                            DateTime s = (DateTime) reader[2];
                            DateTime f = (DateTime)reader[3];
                            if (s >= dtpStart.Value && f <= dtpFinish.Value)
                            {
                                data.Add(new string[3]);
                                data[data.Count - 1][0] = reader[0].ToString();
                                data[data.Count - 1][1] = reader[1].ToString();
                                data[data.Count - 1][2] = reader[2].ToString() + " - " + reader[3].ToString();
                            }
                            
                        }
                        reader.Close();

                        int j = 0;
                        foreach (string[] s in data)
                        {
                            dataGridView1.RowCount += 1;
                            dataGridView1[0, j].Value = s[0];
                            dataGridView1[1, j].Value = s[1];
                            dataGridView1[2, j].Value = s[2];
                            
                            j++;
                        }
                        sqlcon.Close();
                    }

                    break;
            }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            switch (variety)
            {
                case 1:
                    var app = new Application();
                    var wb = app.Workbooks.Add();
                    var ws = wb.Worksheets[1] as Worksheet;
                    ws.Cells[1, 1].Value = "Отчет по ударам со скорость от " + txtFrom.Text + " по " + txtTo.Text;
                    ws.Cells[3, 1].Value = "Speed";
                    ws.Cells[3, 2].Value = "Tenis Player";
                   
                    for (int i = 0; i < dataGridView1.ColumnCount; i++)
                    {
                        for (int j = 0; j < dataGridView1.RowCount; j++)
                        {
                            if (dataGridView1[i, j].Value != null)
                                app.Cells[j + 4, i + 1] = (dataGridView1[i, j].Value).ToString();

                        }
                        app.Visible = true;
                    }
                    wb.SaveAs("Отчет по ударам со скорость от " + txtFrom.Text + " по " + txtTo.Text + ".xlsx");
                    app.Quit();
                    break;
                case 2:
                    if (dataGridView1.Rows.Count != 0)
                    {
                        int RowCount = dataGridView1.Rows.Count;
                        int ColumnCount = dataGridView1.Columns.Count;
                        Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                        //add rows
                        int r = 0;
                        for (int c = 0; c <= ColumnCount - 1; c++)
                        {
                            for (r = 0; r <= RowCount - 1; r++)
                            {
                                DataArray[r, c] = dataGridView1.Rows[r].Cells[c].Value;
                            } //end row loop
                        } //end column loop

                        Word.Document oDoc = new Word.Document();
                        oDoc.Application.Visible = true;

                        //page orintation
                        oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;


                        dynamic oRange = oDoc.Content.Application.Selection.Range;
                        string oTemp = "";
                        for (r = 0; r <= RowCount - 1; r++)
                        {
                            for (int c = 0; c <= ColumnCount - 1; c++)
                            {
                                oTemp = oTemp + DataArray[r, c] + "\t";

                            }
                        }

                        //table format
                        oRange.Text = oTemp;

                        object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                        object ApplyBorders = true;
                        object AutoFit = true;
                        object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                        oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                        Type.Missing, Type.Missing, ref ApplyBorders,
                        Type.Missing, Type.Missing, Type.Missing,
                        Type.Missing, Type.Missing, Type.Missing,
                        Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                        oRange.Select();

                        oDoc.Application.Selection.Tables[1].Select();
                        oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                        oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                        oDoc.Application.Selection.Tables[1].Rows[1].Select();
                        oDoc.Application.Selection.InsertRowsAbove(1);
                        oDoc.Application.Selection.Tables[1].Rows[1].Select();

                        //header row style
                        oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                        oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                        oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                        //add header row manually
                        for (int c = 0; c <= ColumnCount - 1; c++)
                        {
                            oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = dataGridView1.Columns[c].HeaderText;
                        }

                        //table style
                        //oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");
                        oDoc.Application.Selection.Tables[1].Rows[1].Select();
                        oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                        //header text
                        foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                        {
                            Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                            headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                            headerRange.Text = "Отчет по турнирам с " + dtpStart.Value.ToShortDateString() + " по " + dtpFinish.Value.ToShortDateString();

                            headerRange.Font.Size = 16;
                            headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                        }

                        //save the file
                        oDoc.SaveAs("Отчет по турнирам с " + dtpStart.Value.ToShortDateString() + " по " + dtpFinish.Value.ToShortDateString() + ".docx");
                        //oDoc.ClosePrintPreview();

                    }
                    break;
        }
            
        }

        private void BtnChart_Click(object sender, EventArgs e)
        {
            chartTennisPlayers.Visible = true;
            sqlcon.Open();
            dataGridView1.Visible = false;
            btnExport.Visible = false;

            chartTennisPlayers.Titles.Add(@"Char rating of tennis players");

            List<string[]> chardate = new List<string[]>();
           string query = @"select Surname, Rating from TennisPlayers";
           SqlCommand  com = new SqlCommand(query, sqlcon);
           SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                chardate.Add(new string[2]);
                chardate[chardate.Count - 1][0] = reader[0].ToString();
                chardate[chardate.Count - 1][1] = reader[1].ToString();
               
            }
            reader.Close();
         
            foreach (string[] s in chardate)
            {
                chartTennisPlayers.Series["Player"].IsValueShownAsLabel = true;
                chartTennisPlayers.Series["Player"].Points.AddXY(s[0], s[1]);
            }
            sqlcon.Close();

        }

        private void BtnReportByTournament_Click(object sender, EventArgs e)
        {
            variety = 2;
            lblFiltr.Visible = false;
            dtpStart.Visible = true;
            dtpFinish.Visible = true;
            btnGetData.Visible = true;
            lblFrom.Visible = true;
            lblTo.Visible = true;
            dataGridView1.Visible = true;
            chartTennisPlayers.Visible = false;
            dataGridView1.ColumnCount = 3;
            dataGridView1.RowCount = 1;
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            btnExport.Text = "Export to Word";
        }

        private void ChartTennisPlayers_Click(object sender, EventArgs e)
        {

        }
    }
}
