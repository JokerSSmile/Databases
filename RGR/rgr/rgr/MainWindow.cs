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
using System.IO;
using System.Globalization;

namespace rgr
{
    public partial class MainWindow : Form
    {
        private static string updValue;
        private static string id;
        private static string cellHeader;
        private static string imageFileName;
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

        private void insertFlight_Click(object sender, EventArgs e)
        {
            try
            {
                string dTime = textBox1.Text;
                string aTime = textBox2.Text;
                string route = textBox3.Text;

                OleDbCommand cmd = new OleDbCommand("INSERT into Flight (DepartureTime, ArrivalTime, Route, Plane) Values(@dTime, @aTime, @route, @Img)");
                cmd.Connection = conn;

                conn.Open();
                cmd.Parameters.Add("@DepartureTime", OleDbType.DBDate).Value = dTime;
                cmd.Parameters.Add("@ArrivalTime", OleDbType.DBDate).Value = aTime;
                cmd.Parameters.Add("@Route", OleDbType.VarChar).Value = route;
                cmd.Parameters.Add("@Img", OleDbType.Binary).Value = ImageFromFileToByte(imageFileName);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (OleDbException)
            {
                MessageBox.Show("Внутренняя ошибка при работе с БД");
            }
            catch
            {
                MessageBox.Show("Необходимо корректно заполнить данные!\nВозможно не заполнены все поля\nИли неверный формат введенных данных");
            }

            conn.Close();
            LoadTabView();
        }

        private void insertTicket_Click(object sender, EventArgs e)
        {
            try
            {
                string passangerId = textBox5.Text;
                string flightId = textBox4.Text;
                string status = textBox7.Text;

                OleDbCommand cmd = new OleDbCommand("INSERT into Tickets (PassangerId, FlightId, Status) Values(@passangerId, @flightId, @status)");
                cmd.Connection = conn;

                conn.Open();
                cmd.Parameters.Add("@PassangerId", OleDbType.Integer).Value = passangerId;
                cmd.Parameters.Add("@FlightId", OleDbType.Integer).Value = flightId;
                cmd.Parameters.Add("@Status", OleDbType.VarChar).Value = status;

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (OleDbException)
            {
                MessageBox.Show("Внутренняя ошибка при работе с БД");
            }
            catch
            {
                MessageBox.Show("Необходимо корректно заполнить данные!\nВозможно не заполнены все поля\nИли неверный формат введенных данных");
            }

            conn.Close();
            LoadTabView();
        }

        private void insertPassanger_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox6.Text;
                string surname = textBox8.Text;
                string age = textBox9.Text;

                if (int.Parse(age) < 7 || int.Parse(age) > 100)
                {
                    MessageBox.Show("Возраст должен быть в промежутке от 7 до 100 лет!");
                    return;
                }

                OleDbCommand cmd = new OleDbCommand("INSERT into Passangers (PName, PSurname, Age) Values(@name, @surname, @age)");
                cmd.Connection = conn;

                conn.Open();
                cmd.Parameters.Add("@name", OleDbType.VarChar).Value = name;
                cmd.Parameters.Add("@surname", OleDbType.VarChar).Value = surname;
                cmd.Parameters.Add("@age", OleDbType.Integer).Value = age;

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (OleDbException)
            {
                MessageBox.Show("Внутренняя ошибка при работе с БД");
            }
            catch
            {
                MessageBox.Show("Необходимо корректно заполнить данные!\nВозможно не заполнены все поля\nИли неверный формат введенных данных");
            }

            conn.Close();
            LoadTabView();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DataGridView currentGrigView = GetCurrentGridView();

            conn.Open();
            foreach (DataGridViewRow row in currentGrigView.SelectedRows)
            {
                if (row.Selected)
                {
                    string str = currentGrigView.Rows[row.Index].Cells[0].Value.ToString();
                    OleDbCommand cmd = new OleDbCommand("DELETE FROM " + GetCurrentTabName() + " WHERE Id = " + int.Parse(str), conn);
                    cmd.ExecuteNonQuery();
                }
            }
            conn.Close();
            LoadTabView();
        }

        private void update_Click(object sender, EventArgs e)
        {
            Type valueType = null;
            DataGridView currentGrigView = GetCurrentGridView();
            foreach (DataGridViewCell cell in currentGrigView.SelectedCells)
            {
                if (cell.Selected)
                {
                    updValue = currentGrigView.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Value.ToString();
                    id = currentGrigView.Rows[cell.RowIndex].Cells[0].Value.ToString();
                    cellHeader = currentGrigView.Columns[cell.ColumnIndex].HeaderText;
                    valueType = currentGrigView.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Value.GetType();
                }
                break;
            }

            if (updValue != null && cellHeader != "Id" && cellHeader != "Logo")
            {
                UpdatePopUp updatePopUp = new UpdatePopUp(this, valueType);
                updatePopUp.Show();
            }
        }

        public void onUpdateFormClose(object value)
        { 
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("UPDATE " + GetCurrentTabName() + " SET " + cellHeader + " = '" + value + "' WHERE Id = " + id + ";", conn);
                cmd.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch
            {
                MessageBox.Show("Необходимо корректно заполнить данные!");
            }

            conn.Close();
            LoadTabView();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadTabView();
        }

        private string GetCurrentTabName()
        {
            return tableTabs.SelectedTab.Text;
        }

        private DataGridView GetCurrentGridView()
        {
            string currentTab = GetCurrentTabName();
            if (currentTab == "Flight")
            {
                return flightDataGridView;
            }
            else if (currentTab == "Tickets")
            {
                return ticketsDataGridView;
            }
            else if (currentTab == "Passangers")
            {
                return passangersDataGridView;
            }
            return null;
        }

        private void FlightDataGridView_RowHeaderMouseClick(object sender, EventArgs e)
        {
            string id = flightDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            flightSupportingGridView.DataSource = FillTable("SELECT * FROM Tickets WHERE FlightId = " + id + ";");
        }

        private void PassangersDataGridView_RowHeaderMouseClick(object sender, EventArgs e)
        {
            string id = passangersDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            passangersSupportingGridView.DataSource = FillTable("SELECT * FROM Tickets WHERE PassangerId = " + id + ";");
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "BMP Image|*.bmp";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                imageFileName = fileDialog.FileName;
            }
        }

        public byte[] ImageFromFileToByte(string filename)
        {
            Bitmap bmp = new Bitmap(filename);
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(bmp, typeof(byte[]));
        }

        private void searchFlightButton_Click(object sender, EventArgs e)
        {
            string firstParam = textBox1.Text == "" ? null : "DepartureTime = '" + textBox1.Text + "'";
            string secondParam = textBox2.Text == "" ? null : "ArrivalTime = '" + textBox2.Text + "'";
            //string secondParam = textBox2.Text == "" ? null : "STR_TO_DATE('ArrivalTime', '%dd, %mm, %yy')=" + textBox2.Text + " ";
            string thirdParam = textBox3.Text == "" ? null : "Route = '" + textBox3.Text + "'";
            //flightDataGridView.DataSource = FillTable("SELECT * FROM Flight WHERE " + firstParam + secondParam + thirdParam + " ;");
            flightDataGridView.DataSource = FillTable("SELECT * FROM Flight WHERE \"ArrivalTime\"=\"05.01.2017\";");
        }

        private void searchTicketsButton_Click(object sender, EventArgs e)
        {
            string firstParam = textBox5.Text == "" ? null : "PassangerId = " + textBox5.Text + " ";
            string secondParam = textBox4.Text == "" ? null : "FlightId = " + textBox4.Text + " ";
            string thirdParam = textBox7.Text == "" ? null : "Status = '" + textBox7.Text + "'";
            ticketsDataGridView.DataSource = FillTable("SELECT * FROM Tickets WHERE " + firstParam +
                (secondParam == null ? null : "AND ") + secondParam + (thirdParam == null ? null: "AND ") + thirdParam + " ;");

        }
    }
}
