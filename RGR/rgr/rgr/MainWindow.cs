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
        private static string currentSelectInPassangers;
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
            loadTabView();
        }

        public void loadTabView()
        {
            sb = new OleDbConnectionStringBuilder();
            sb.Provider = "Microsoft.ACE.OLEDB.15.0";
            sb.DataSource = @"C:\Users\oleg\Documents\Visual Studio 2015\Projects\Database\rgr\rgr\rgrDB.accdb";
            conn = new OleDbConnection(sb.ConnectionString);
            flightDataGridView.DataSource = fillTable("SELECT * FROM Flight");
            ticketsDataGridView.DataSource = fillTable("SELECT * FROM Tickets");
            passangersDataGridView.DataSource = fillTable("SELECT * FROM Passangers");
            currentSelectInPassangers = "";
            updateAverageValue(null, null);
        }

        private DataTable fillTable(string sql)
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

        private DataTable fillTable(OleDbCommand cmd)
        {
            DataTable table = new DataTable();
            using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
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
                cmd.Parameters.Add("@Img", OleDbType.Binary).Value = imageFromFileToByte(imageFileName);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (OleDbException)
            {
                MessageBox.Show("Внутренняя ошибка при работе с БД");
            }
            catch
            {
                MessageBox.Show("Необходимо корректно заполнить данные!\nВсе поля обязательны для заполнения!\nИли неверный формат введенных данных");
            }
            finally
            {
                conn.Close();
            }
            loadTabView();
        }

        private void insertTicket_Click(object sender, EventArgs e)
        {
            try
            {
                string passangerId = passangerIdComboBox.Text;
                string flightId = flightIdComboBox.Text;
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
                MessageBox.Show("Необходимо корректно заполнить данные!\nВсе поля обязательны для заполнения!\nИли неверный формат введенных данных");
            }
            finally
            {
                conn.Close();
            }

            loadTabView();
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
                MessageBox.Show("Необходимо корректно заполнить данные!\nВсе поля обязательны для заполнения!\nИли неверный формат введенных данных");
            }
            finally
            {
                conn.Close();
            }

            loadTabView();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DataGridView currentGrigView = getCurrentGridView();

            conn.Open();
            foreach (DataGridViewRow row in currentGrigView.SelectedRows)
            {
                if (row.Selected)
                {
                    string str = currentGrigView.Rows[row.Index].Cells[0].Value.ToString();
                    OleDbCommand cmd = new OleDbCommand("DELETE FROM " + getCurrentTabName() + " WHERE Id = " + int.Parse(str), conn);
                    cmd.ExecuteNonQuery();
                }
            }
            conn.Close();
            loadTabView();
        }

        private void update_Click(object sender, EventArgs e)
        {
            Type valueType = null;
            DataGridView currentGrigView = getCurrentGridView();
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
            string sValue = value.ToString();
            if (cellHeader == "DepartureTime" || cellHeader == "ArrivalTime")
            {
                try
                {
                    DateTime dt = DateTime.Parse(sValue);
                    sValue = dt.ToShortDateString();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Неверный формат даты");
                }
            }
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("UPDATE " + getCurrentTabName() + " SET " + cellHeader + " = '" + sValue + "' WHERE Id = " + id + ";", conn);
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
            finally
            {
                conn.Close();
            }

            loadTabView();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadTabView();
        }

        private string getCurrentTabName()
        {
            return tableTabs.SelectedTab.Text;
        }

        private DataGridView getCurrentGridView()
        {
            string currentTab = getCurrentTabName();
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

        private void flightDataGridView_RowHeaderMouseClick(object sender, EventArgs e)
        {
            string id = flightDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            //flightSupportingGridView.DataSource = fillTable("SELECT * FROM Tickets WHERE FlightId = " + id + ";");
            //flightSupportingGridView.DataSource = fillTable("SELECT * FROM [Passangers] p JOIN Tickets t ON p.Id=t.PassangerId JOIN Flight f ON f.Id=t.FlightId;");
            flightSupportingGridView.DataSource = fillTable("SELECT * FROM Passangers LEFT JOIN Tickets ON Passangers.Id = Tickets.PassangerId WHERE Tickets.FlightId = " + id + ";");
        }

        private void passangersDataGridView_RowHeaderMouseClick(object sender, EventArgs e)
        {
            string id = passangersDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            passangersSupportingGridView.DataSource = fillTable("SELECT * FROM Tickets WHERE PassangerId = " + id + ";");
        }

        private void ticketsDataGridView_RowHeaderMouseClick(object sender, EventArgs e)
        {
            string passangerId = ticketsDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            string flightId = ticketsDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            ticketsFlightsDataGridView.DataSource = fillTable("SELECT * FROM Flight WHERE Id = " + flightId + ";");
            ticketsPassangersDataGridView.DataSource = fillTable("SELECT * FROM Passangers WHERE Id = " + passangerId + ";");
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

        public byte[] imageFromFileToByte(string filename)
        {
            Bitmap bmp = new Bitmap(filename);
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(bmp, typeof(byte[]));
        }

        private void searchFlightButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
            {
                ticketsDataGridView.DataSource = fillTable("SELECT * FROM Flight;");
                return;
            }
            string sqlQuery = "SELECT * FROM Flight WHERE ";
            sqlQuery += textBox1.Text == "" ? "DepartureTime IS NOT NULL AND " : "DepartureTime=DateValue('" + textBox1.Text + "') AND ";
            sqlQuery += textBox2.Text == "" ? "ArrivalTime IS NOT NULL AND " : "ArrivalTime=DateValue('" + textBox2.Text + "') AND ";
            sqlQuery += textBox3.Text == "" ? "Route IS NOT NULL" : "Route='" + textBox3.Text + "'";
            sqlQuery += ";";

            flightDataGridView.DataSource = fillTable(sqlQuery);
        }

        private void searchTicketsButton_Click(object sender, EventArgs e)
        {
            if (passangerIdComboBox.Text == "" && flightIdComboBox.Text == "" && textBox7.Text == "")
            {
                ticketsDataGridView.DataSource = fillTable("SELECT * FROM Tickets;");
                return;
            }
            string sqlQuery = "SELECT * FROM Tickets WHERE ";
            sqlQuery += passangerIdComboBox.Text == "" ? "PassangerId IS NOT NULL AND " : "PassangerId=" + passangerIdComboBox.Text + " AND ";
            sqlQuery += flightIdComboBox.Text == "" ? "FlightId IS NOT NULL AND " : "FlightId=" + flightIdComboBox.Text + " AND ";
            sqlQuery += textBox7.Text == "" ? "Status IS NOT NULL" : "Status='" + textBox7.Text + "'";
            sqlQuery += ";";

            ticketsDataGridView.DataSource = fillTable(sqlQuery);
        }

        private void searchPassangersButton_Click(object sender, EventArgs e)
        {
            string sqlQuery = "";
            if (textBox6.Text == "" && textBox8.Text == "" && textBox9.Text == "")
            {
                currentSelectInPassangers = sqlQuery;
                passangersDataGridView.DataSource = fillTable("SELECT * FROM Passangers;");
                return;
            }
            string sqlBase = "SELECT * FROM Passangers WHERE ";
            sqlQuery += textBox6.Text == "" ? "PName IS NOT NULL AND " : "PName='" + textBox6.Text + "' AND ";
            sqlQuery += textBox8.Text == "" ? "PSurname IS NOT NULL AND " : "PSurname='" + textBox8.Text + "' AND ";
            sqlQuery += textBox9.Text == "" ? "Age IS NOT NULL" : "Age=" + textBox9.Text+ "";
            sqlQuery += ";";
            currentSelectInPassangers = sqlQuery;

            passangersDataGridView.DataSource = fillTable(sqlBase + sqlQuery);
            updateAverageValue(null, null);
        }

        private void passangerIdComboBox_Click(object sender, EventArgs e)
        {
            List<string> passangersIds = passangersDataGridView.Rows
                             .OfType<DataGridViewRow>()
                             .Select(row => row.Cells[0].Value.ToString())
                             .ToList();

            passangerIdComboBox.Items.Clear();
            passangerIdComboBox.Items.AddRange(passangersIds.ToArray());
        }

        private void flightIdComboBox_Click(object sender, EventArgs e)
        {
            List<string> flightsIds = flightDataGridView.Rows
                             .OfType<DataGridViewRow>()
                             .Select(row => row.Cells[0].Value.ToString())
                             .ToList();

            flightIdComboBox.Items.Clear();
            flightIdComboBox.Items.AddRange(flightsIds.ToArray());
        }

        private void updateAverageValue(object sender, EventArgs e)
        {
            if (tableTabs.SelectedIndex == 2)
            {
                conn.Open();
                string sqlQuery = "SELECT AVG(Age) FROM Passangers";
                string selectQuery = currentSelectInPassangers;
                if (selectQuery != "")
                {
                    sqlQuery += " WHERE " + selectQuery;
                }
                else
                {
                    sqlQuery += ";";
                }
                OleDbCommand com = new OleDbCommand(sqlQuery, conn);
                try
                {
                    textBox4.Text = com.ExecuteScalar().ToString();
                }
                catch (Exception){	}
                conn.Close();
            }
        }

        private void passangersListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportWindow report = new ReportWindow(0);
            report.Show();
        }

        private void flightsInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportWindow report = new ReportWindow(1);
            report.Show();
        }

    }
}
