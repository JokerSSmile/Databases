using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace rgr
{
    public partial class MainWindow : Form
    {
        private static string updValue;
        private static string id;
        private static string cellHeader;
        private static OleDbConnection conn;
        private static OleDbConnectionStringBuilder sb;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            LoadTabView();
        }

        public void LoadTabView()
        {
            sb = new OleDbConnectionStringBuilder();
            sb.Provider = "Microsoft.ACE.OLEDB.15.0";
            sb.DataSource = @"C:\Users\oleg\Documents\Visual Studio 2015\Projects\Database\rgr\rgr\rgrDB.accdb";
            conn = new OleDbConnection(sb.ConnectionString);
            flightDataGridView.DataSource = FillTable("SELECT * FROM Flight");
            ticketsDataGridView.DataSource = FillTable("SELECT * FROM Tickets");
            passangersDataGridView.DataSource = FillTable("SELECT * FROM Passangers");
        }

        private DataTable FillTable(string sql)
        {
            DataTable table = new DataTable();
            using (OleDbDataAdapter da = new OleDbDataAdapter(sql, conn))
            {
                try
                {
                    da.Fill(table);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show(ex.Message);
                }
                
            }
            return table;
        }

        private void button4_Click(object sender, EventArgs e)
        {   
            
        }

        private void insertFlight_Click(object sender, EventArgs e)
        {
            try
            {
                string dTime = textBox1.Text;
                string aTime = textBox2.Text;
                string route = textBox3.Text;

                OleDbCommand cmd = new OleDbCommand("INSERT into Flight (DepartureTime, ArrivalTime, Route) Values(@dTime, @aTime, @Route)");
                cmd.Connection = conn;

                conn.Open();
                cmd.Parameters.Add("@DepartureTime", OleDbType.DBDate).Value = dTime;
                cmd.Parameters.Add("@ArrivalTime", OleDbType.DBDate).Value = aTime;
                cmd.Parameters.Add("@Route", OleDbType.VarChar).Value = route;

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Source);
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Необходимо корректно заполнить данные!");
            }

            LoadTabView();
        }

        private void deleteFlight_Click(object sender, EventArgs e)
        {
            conn.Open();
            foreach (DataGridViewRow row in flightDataGridView.SelectedRows)
            {
                if (row.Selected)
                {
                    string str = flightDataGridView.Rows[row.Index].Cells[0].Value.ToString();
                    OleDbCommand cmd = new OleDbCommand("DELETE FROM Flight WHERE Id = " + int.Parse(str), conn);
                    cmd.ExecuteNonQuery();
                }
            }
            conn.Close();
            LoadTabView();
        }

        private void updateFlight_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in flightDataGridView.SelectedCells)
            {
                if (cell.Selected)
                {
                    updValue = flightDataGridView.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Value.ToString();
                    id = flightDataGridView.Rows[cell.RowIndex].Cells[0].Value.ToString();
                    cellHeader = flightDataGridView.Columns[cell.ColumnIndex].HeaderText;
                    break;
                }
            }

            if (updValue != null && cellHeader != "Id")
            {
                UpdatePopUp updatePopUp = new UpdatePopUp();
                updatePopUp.ShowDialog();
            }

            Console.WriteLine(updValue + " " + id + " "  + cellHeader);
        }

        public static void onUpdateFormClose(string value)
        {
            conn.Open();
            try
            {
                OleDbCommand cmd = new OleDbCommand("UPDATE Flight SET " + cellHeader + " = '" + value + "' WHERE Id = " + id + ";", conn);
                cmd.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Source);
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Необходимо корректно заполнить данные!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadTabView();
        }
    }
}
