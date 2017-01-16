namespace rgr
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passangersListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flightsInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableTabs = new System.Windows.Forms.TabControl();
            this.tabPageFlights = new System.Windows.Forms.TabPage();
            this.searchFlightButton = new System.Windows.Forms.Button();
            this.flightDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plane = new System.Windows.Forms.DataGridViewImageColumn();
            this.flightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rgrDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rgrDBDataSet = new rgr.rgrDBDataSet();
            this.browseButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.flightSupportingGridView = new System.Windows.Forms.DataGridView();
            this.passangersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.flightBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.insertFlight = new System.Windows.Forms.Button();
            this.tabPageTickets = new System.Windows.Forms.TabPage();
            this.ticketsPassangersDataGridView = new System.Windows.Forms.DataGridView();
            this.pNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketsFlightsDataGridView = new System.Windows.Forms.DataGridView();
            this.departureTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.flightIdComboBox = new System.Windows.Forms.ComboBox();
            this.passangerIdComboBox = new System.Windows.Forms.ComboBox();
            this.searchTicketsButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.ticketsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.insertTicket = new System.Windows.Forms.Button();
            this.tabPagePassangers = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.searchPassangersButton = new System.Windows.Forms.Button();
            this.passangersSupportingGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.passangersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.insertPassanger = new System.Windows.Forms.Button();
            this.ticketsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.flightTableAdapter = new rgr.rgrDBDataSetTableAdapters.FlightTableAdapter();
            this.ticketsTableAdapter = new rgr.rgrDBDataSetTableAdapters.TicketsTableAdapter();
            this.passangersTableAdapter = new rgr.rgrDBDataSetTableAdapters.PassangersTableAdapter();
            this.tableAdapterManager = new rgr.rgrDBDataSetTableAdapters.TableAdapterManager();
            this.pNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pSurnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.tableTabs.SuspendLayout();
            this.tabPageFlights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgrDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgrDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightSupportingGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passangersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource1)).BeginInit();
            this.tabPageTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsPassangersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsFlightsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).BeginInit();
            this.tabPagePassangers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passangersSupportingGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passangersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.printToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1144, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passangersListToolStripMenuItem,
            this.flightsInfoToolStripMenuItem});
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // passangersListToolStripMenuItem
            // 
            this.passangersListToolStripMenuItem.Name = "passangersListToolStripMenuItem";
            this.passangersListToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.passangersListToolStripMenuItem.Text = "Passangers list";
            this.passangersListToolStripMenuItem.Click += new System.EventHandler(this.passangersListToolStripMenuItem_Click);
            // 
            // flightsInfoToolStripMenuItem
            // 
            this.flightsInfoToolStripMenuItem.Name = "flightsInfoToolStripMenuItem";
            this.flightsInfoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.flightsInfoToolStripMenuItem.Text = "Tickets info";
            this.flightsInfoToolStripMenuItem.Click += new System.EventHandler(this.flightsInfoToolStripMenuItem_Click);
            // 
            // tableTabs
            // 
            this.tableTabs.Controls.Add(this.tabPageFlights);
            this.tableTabs.Controls.Add(this.tabPageTickets);
            this.tableTabs.Controls.Add(this.tabPagePassangers);
            this.tableTabs.Location = new System.Drawing.Point(12, 27);
            this.tableTabs.Name = "tableTabs";
            this.tableTabs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableTabs.SelectedIndex = 0;
            this.tableTabs.Size = new System.Drawing.Size(1123, 292);
            this.tableTabs.TabIndex = 1;
            this.tableTabs.Selected += new System.Windows.Forms.TabControlEventHandler(this.updateAverageValue);
            // 
            // tabPageFlights
            // 
            this.tabPageFlights.AutoScroll = true;
            this.tabPageFlights.Controls.Add(this.searchFlightButton);
            this.tabPageFlights.Controls.Add(this.flightDataGridView);
            this.tabPageFlights.Controls.Add(this.browseButton);
            this.tabPageFlights.Controls.Add(this.label10);
            this.tabPageFlights.Controls.Add(this.flightSupportingGridView);
            this.tabPageFlights.Controls.Add(this.label3);
            this.tabPageFlights.Controls.Add(this.label2);
            this.tabPageFlights.Controls.Add(this.label1);
            this.tabPageFlights.Controls.Add(this.textBox3);
            this.tabPageFlights.Controls.Add(this.textBox2);
            this.tabPageFlights.Controls.Add(this.textBox1);
            this.tabPageFlights.Controls.Add(this.insertFlight);
            this.tabPageFlights.Location = new System.Drawing.Point(4, 22);
            this.tabPageFlights.Name = "tabPageFlights";
            this.tabPageFlights.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFlights.Size = new System.Drawing.Size(1115, 266);
            this.tabPageFlights.TabIndex = 0;
            this.tabPageFlights.Text = "Flight";
            this.tabPageFlights.UseVisualStyleBackColor = true;
            // 
            // searchFlightButton
            // 
            this.searchFlightButton.Location = new System.Drawing.Point(428, 235);
            this.searchFlightButton.Name = "searchFlightButton";
            this.searchFlightButton.Size = new System.Drawing.Size(89, 25);
            this.searchFlightButton.TabIndex = 15;
            this.searchFlightButton.Text = "Search";
            this.searchFlightButton.UseVisualStyleBackColor = true;
            this.searchFlightButton.Click += new System.EventHandler(this.searchFlightButton_Click);
            // 
            // flightDataGridView
            // 
            this.flightDataGridView.AllowUserToAddRows = false;
            this.flightDataGridView.AllowUserToDeleteRows = false;
            this.flightDataGridView.AutoGenerateColumns = false;
            this.flightDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flightDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.departureTimeDataGridViewTextBoxColumn,
            this.arrivalTimeDataGridViewTextBoxColumn,
            this.routeDataGridViewTextBoxColumn,
            this.Plane});
            this.flightDataGridView.DataSource = this.flightBindingSource;
            this.flightDataGridView.Location = new System.Drawing.Point(9, 6);
            this.flightDataGridView.MinimumSize = new System.Drawing.Size(0, 64);
            this.flightDataGridView.Name = "flightDataGridView";
            this.flightDataGridView.ReadOnly = true;
            this.flightDataGridView.RowTemplate.Height = 64;
            this.flightDataGridView.Size = new System.Drawing.Size(660, 184);
            this.flightDataGridView.TabIndex = 14;
            this.flightDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.flightDataGridView_RowHeaderMouseClick);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // departureTimeDataGridViewTextBoxColumn
            // 
            this.departureTimeDataGridViewTextBoxColumn.DataPropertyName = "DepartureTime";
            this.departureTimeDataGridViewTextBoxColumn.HeaderText = "DepartureTime";
            this.departureTimeDataGridViewTextBoxColumn.Name = "departureTimeDataGridViewTextBoxColumn";
            this.departureTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // arrivalTimeDataGridViewTextBoxColumn
            // 
            this.arrivalTimeDataGridViewTextBoxColumn.DataPropertyName = "ArrivalTime";
            this.arrivalTimeDataGridViewTextBoxColumn.HeaderText = "ArrivalTime";
            this.arrivalTimeDataGridViewTextBoxColumn.Name = "arrivalTimeDataGridViewTextBoxColumn";
            this.arrivalTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // routeDataGridViewTextBoxColumn
            // 
            this.routeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.routeDataGridViewTextBoxColumn.DataPropertyName = "Route";
            this.routeDataGridViewTextBoxColumn.HeaderText = "Route";
            this.routeDataGridViewTextBoxColumn.Name = "routeDataGridViewTextBoxColumn";
            this.routeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Plane
            // 
            this.Plane.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Plane.DataPropertyName = "Plane";
            this.Plane.HeaderText = "Logo";
            this.Plane.Name = "Plane";
            this.Plane.ReadOnly = true;
            this.Plane.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Plane.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // flightBindingSource
            // 
            this.flightBindingSource.DataMember = "Flight";
            this.flightBindingSource.DataSource = this.rgrDBDataSetBindingSource;
            // 
            // rgrDBDataSetBindingSource
            // 
            this.rgrDBDataSetBindingSource.DataSource = this.rgrDBDataSet;
            this.rgrDBDataSetBindingSource.Position = 0;
            // 
            // rgrDBDataSet
            // 
            this.rgrDBDataSet.DataSetName = "rgrDBDataSet";
            this.rgrDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(523, 209);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(89, 20);
            this.browseButton.TabIndex = 14;
            this.browseButton.Text = "Browse..";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(520, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Image";
            // 
            // flightSupportingGridView
            // 
            this.flightSupportingGridView.AllowUserToAddRows = false;
            this.flightSupportingGridView.AllowUserToDeleteRows = false;
            this.flightSupportingGridView.AutoGenerateColumns = false;
            this.flightSupportingGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flightSupportingGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pNameDataGridViewTextBoxColumn1,
            this.pSurnameDataGridViewTextBoxColumn1,
            this.ageDataGridViewTextBoxColumn1});
            this.flightSupportingGridView.DataSource = this.passangersBindingSource;
            this.flightSupportingGridView.Location = new System.Drawing.Point(675, 6);
            this.flightSupportingGridView.Name = "flightSupportingGridView";
            this.flightSupportingGridView.ReadOnly = true;
            this.flightSupportingGridView.Size = new System.Drawing.Size(433, 254);
            this.flightSupportingGridView.TabIndex = 5;
            // 
            // passangersBindingSource
            // 
            this.passangersBindingSource.DataMember = "Passangers";
            this.passangersBindingSource.DataSource = this.rgrDBDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Route";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "A. time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "D. time";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightBindingSource1, "Route", true));
            this.textBox3.Location = new System.Drawing.Point(231, 209);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(286, 20);
            this.textBox3.TabIndex = 8;
            // 
            // flightBindingSource1
            // 
            this.flightBindingSource1.DataMember = "Flight";
            this.flightBindingSource1.DataSource = this.rgrDBDataSet;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightBindingSource1, "ArrivalTime", true));
            this.textBox2.Location = new System.Drawing.Point(115, 209);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(110, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightBindingSource1, "DepartureTime", true));
            this.textBox1.Location = new System.Drawing.Point(9, 209);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // insertFlight
            // 
            this.insertFlight.Location = new System.Drawing.Point(9, 235);
            this.insertFlight.Name = "insertFlight";
            this.insertFlight.Size = new System.Drawing.Size(89, 25);
            this.insertFlight.TabIndex = 5;
            this.insertFlight.Text = "Insert";
            this.insertFlight.UseVisualStyleBackColor = true;
            this.insertFlight.Click += new System.EventHandler(this.insertFlight_Click);
            // 
            // tabPageTickets
            // 
            this.tabPageTickets.AutoScroll = true;
            this.tabPageTickets.Controls.Add(this.ticketsPassangersDataGridView);
            this.tabPageTickets.Controls.Add(this.ticketsFlightsDataGridView);
            this.tabPageTickets.Controls.Add(this.flightIdComboBox);
            this.tabPageTickets.Controls.Add(this.passangerIdComboBox);
            this.tabPageTickets.Controls.Add(this.searchTicketsButton);
            this.tabPageTickets.Controls.Add(this.label7);
            this.tabPageTickets.Controls.Add(this.textBox7);
            this.tabPageTickets.Controls.Add(this.ticketsDataGridView);
            this.tabPageTickets.Controls.Add(this.label5);
            this.tabPageTickets.Controls.Add(this.label4);
            this.tabPageTickets.Controls.Add(this.insertTicket);
            this.tabPageTickets.Location = new System.Drawing.Point(4, 22);
            this.tabPageTickets.Name = "tabPageTickets";
            this.tabPageTickets.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTickets.Size = new System.Drawing.Size(1115, 266);
            this.tabPageTickets.TabIndex = 1;
            this.tabPageTickets.Text = "Tickets";
            this.tabPageTickets.UseVisualStyleBackColor = true;
            // 
            // ticketsPassangersDataGridView
            // 
            this.ticketsPassangersDataGridView.AllowUserToAddRows = false;
            this.ticketsPassangersDataGridView.AllowUserToDeleteRows = false;
            this.ticketsPassangersDataGridView.AutoGenerateColumns = false;
            this.ticketsPassangersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketsPassangersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pNameDataGridViewTextBoxColumn,
            this.pSurnameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn});
            this.ticketsPassangersDataGridView.DataSource = this.passangersBindingSource;
            this.ticketsPassangersDataGridView.Location = new System.Drawing.Point(674, 138);
            this.ticketsPassangersDataGridView.Name = "ticketsPassangersDataGridView";
            this.ticketsPassangersDataGridView.ReadOnly = true;
            this.ticketsPassangersDataGridView.Size = new System.Drawing.Size(434, 122);
            this.ticketsPassangersDataGridView.TabIndex = 20;
            // 
            // pNameDataGridViewTextBoxColumn
            // 
            this.pNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pNameDataGridViewTextBoxColumn.DataPropertyName = "PName";
            this.pNameDataGridViewTextBoxColumn.HeaderText = "PName";
            this.pNameDataGridViewTextBoxColumn.Name = "pNameDataGridViewTextBoxColumn";
            this.pNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pSurnameDataGridViewTextBoxColumn
            // 
            this.pSurnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pSurnameDataGridViewTextBoxColumn.DataPropertyName = "PSurname";
            this.pSurnameDataGridViewTextBoxColumn.HeaderText = "PSurname";
            this.pSurnameDataGridViewTextBoxColumn.Name = "pSurnameDataGridViewTextBoxColumn";
            this.pSurnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ticketsFlightsDataGridView
            // 
            this.ticketsFlightsDataGridView.AllowUserToAddRows = false;
            this.ticketsFlightsDataGridView.AllowUserToDeleteRows = false;
            this.ticketsFlightsDataGridView.AutoGenerateColumns = false;
            this.ticketsFlightsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketsFlightsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departureTimeDataGridViewTextBoxColumn1,
            this.arrivalTimeDataGridViewTextBoxColumn1,
            this.routeDataGridViewTextBoxColumn1,
            this.planeDataGridViewTextBoxColumn});
            this.ticketsFlightsDataGridView.DataSource = this.flightBindingSource;
            this.ticketsFlightsDataGridView.Location = new System.Drawing.Point(674, 6);
            this.ticketsFlightsDataGridView.MinimumSize = new System.Drawing.Size(0, 64);
            this.ticketsFlightsDataGridView.Name = "ticketsFlightsDataGridView";
            this.ticketsFlightsDataGridView.ReadOnly = true;
            this.ticketsFlightsDataGridView.Size = new System.Drawing.Size(435, 126);
            this.ticketsFlightsDataGridView.TabIndex = 19;
            // 
            // departureTimeDataGridViewTextBoxColumn1
            // 
            this.departureTimeDataGridViewTextBoxColumn1.DataPropertyName = "DepartureTime";
            this.departureTimeDataGridViewTextBoxColumn1.HeaderText = "DepartureTime";
            this.departureTimeDataGridViewTextBoxColumn1.Name = "departureTimeDataGridViewTextBoxColumn1";
            this.departureTimeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // arrivalTimeDataGridViewTextBoxColumn1
            // 
            this.arrivalTimeDataGridViewTextBoxColumn1.DataPropertyName = "ArrivalTime";
            this.arrivalTimeDataGridViewTextBoxColumn1.HeaderText = "ArrivalTime";
            this.arrivalTimeDataGridViewTextBoxColumn1.Name = "arrivalTimeDataGridViewTextBoxColumn1";
            this.arrivalTimeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // routeDataGridViewTextBoxColumn1
            // 
            this.routeDataGridViewTextBoxColumn1.DataPropertyName = "Route";
            this.routeDataGridViewTextBoxColumn1.HeaderText = "Route";
            this.routeDataGridViewTextBoxColumn1.Name = "routeDataGridViewTextBoxColumn1";
            this.routeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // planeDataGridViewTextBoxColumn
            // 
            this.planeDataGridViewTextBoxColumn.DataPropertyName = "Plane";
            this.planeDataGridViewTextBoxColumn.HeaderText = "Plane";
            this.planeDataGridViewTextBoxColumn.Name = "planeDataGridViewTextBoxColumn";
            this.planeDataGridViewTextBoxColumn.ReadOnly = true;
            this.planeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.planeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // flightIdComboBox
            // 
            this.flightIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.flightIdComboBox.Location = new System.Drawing.Point(118, 209);
            this.flightIdComboBox.Name = "flightIdComboBox";
            this.flightIdComboBox.Size = new System.Drawing.Size(112, 21);
            this.flightIdComboBox.TabIndex = 18;
            this.flightIdComboBox.Click += new System.EventHandler(this.flightIdComboBox_Click);
            // 
            // passangerIdComboBox
            // 
            this.passangerIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.passangerIdComboBox.Location = new System.Drawing.Point(6, 209);
            this.passangerIdComboBox.Name = "passangerIdComboBox";
            this.passangerIdComboBox.Size = new System.Drawing.Size(106, 21);
            this.passangerIdComboBox.TabIndex = 17;
            this.passangerIdComboBox.Click += new System.EventHandler(this.passangerIdComboBox_Click);
            // 
            // searchTicketsButton
            // 
            this.searchTicketsButton.Location = new System.Drawing.Point(267, 235);
            this.searchTicketsButton.Name = "searchTicketsButton";
            this.searchTicketsButton.Size = new System.Drawing.Size(89, 25);
            this.searchTicketsButton.TabIndex = 16;
            this.searchTicketsButton.Text = "Search";
            this.searchTicketsButton.UseVisualStyleBackColor = true;
            this.searchTicketsButton.Click += new System.EventHandler(this.searchTicketsButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(233, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Status";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(236, 209);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(116, 20);
            this.textBox7.TabIndex = 14;
            // 
            // ticketsDataGridView
            // 
            this.ticketsDataGridView.AllowUserToAddRows = false;
            this.ticketsDataGridView.AllowUserToDeleteRows = false;
            this.ticketsDataGridView.AutoGenerateColumns = false;
            this.ticketsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn12});
            this.ticketsDataGridView.DataSource = this.ticketsBindingSource;
            this.ticketsDataGridView.Location = new System.Drawing.Point(6, 6);
            this.ticketsDataGridView.Name = "ticketsDataGridView";
            this.ticketsDataGridView.ReadOnly = true;
            this.ticketsDataGridView.Size = new System.Drawing.Size(663, 184);
            this.ticketsDataGridView.TabIndex = 13;
            this.ticketsDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ticketsDataGridView_RowHeaderMouseClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn3.HeaderText = "Id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PassangerId";
            this.dataGridViewTextBoxColumn4.HeaderText = "PassangerId";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FlightId";
            this.dataGridViewTextBoxColumn5.HeaderText = "FlightId";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn12.HeaderText = "Status";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // ticketsBindingSource
            // 
            this.ticketsBindingSource.DataMember = "Tickets";
            this.ticketsBindingSource.DataSource = this.rgrDBDataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Flight Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Passanger Id";
            // 
            // insertTicket
            // 
            this.insertTicket.Location = new System.Drawing.Point(9, 235);
            this.insertTicket.Name = "insertTicket";
            this.insertTicket.Size = new System.Drawing.Size(89, 25);
            this.insertTicket.TabIndex = 8;
            this.insertTicket.Text = "Insert";
            this.insertTicket.UseVisualStyleBackColor = true;
            this.insertTicket.Click += new System.EventHandler(this.insertTicket_Click);
            // 
            // tabPagePassangers
            // 
            this.tabPagePassangers.AutoScroll = true;
            this.tabPagePassangers.Controls.Add(this.label11);
            this.tabPagePassangers.Controls.Add(this.textBox4);
            this.tabPagePassangers.Controls.Add(this.searchPassangersButton);
            this.tabPagePassangers.Controls.Add(this.passangersSupportingGridView);
            this.tabPagePassangers.Controls.Add(this.label9);
            this.tabPagePassangers.Controls.Add(this.textBox9);
            this.tabPagePassangers.Controls.Add(this.label8);
            this.tabPagePassangers.Controls.Add(this.textBox8);
            this.tabPagePassangers.Controls.Add(this.passangersDataGridView);
            this.tabPagePassangers.Controls.Add(this.label6);
            this.tabPagePassangers.Controls.Add(this.textBox6);
            this.tabPagePassangers.Controls.Add(this.insertPassanger);
            this.tabPagePassangers.Location = new System.Drawing.Point(4, 22);
            this.tabPagePassangers.Name = "tabPagePassangers";
            this.tabPagePassangers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePassangers.Size = new System.Drawing.Size(1115, 266);
            this.tabPagePassangers.TabIndex = 2;
            this.tabPagePassangers.Text = "Passangers";
            this.tabPagePassangers.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(438, 193);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Average:";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(494, 190);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(175, 20);
            this.textBox4.TabIndex = 20;
            // 
            // searchPassangersButton
            // 
            this.searchPassangersButton.Location = new System.Drawing.Point(241, 235);
            this.searchPassangersButton.Name = "searchPassangersButton";
            this.searchPassangersButton.Size = new System.Drawing.Size(89, 25);
            this.searchPassangersButton.TabIndex = 19;
            this.searchPassangersButton.Text = "Search";
            this.searchPassangersButton.UseVisualStyleBackColor = true;
            this.searchPassangersButton.Click += new System.EventHandler(this.searchPassangersButton_Click);
            // 
            // passangersSupportingGridView
            // 
            this.passangersSupportingGridView.AllowUserToAddRows = false;
            this.passangersSupportingGridView.AllowUserToDeleteRows = false;
            this.passangersSupportingGridView.AutoGenerateColumns = false;
            this.passangersSupportingGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.passangersSupportingGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.passangersSupportingGridView.DataSource = this.ticketsBindingSource;
            this.passangersSupportingGridView.Location = new System.Drawing.Point(675, 6);
            this.passangersSupportingGridView.Name = "passangersSupportingGridView";
            this.passangersSupportingGridView.ReadOnly = true;
            this.passangersSupportingGridView.Size = new System.Drawing.Size(434, 254);
            this.passangersSupportingGridView.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn13.HeaderText = "Id";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "FlightId";
            this.dataGridViewTextBoxColumn15.HeaderText = "FlightId";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn16.HeaderText = "Status";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(224, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Age";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(227, 209);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(103, 20);
            this.textBox9.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(115, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Surname";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(118, 209);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(103, 20);
            this.textBox8.TabIndex = 15;
            // 
            // passangersDataGridView
            // 
            this.passangersDataGridView.AllowUserToAddRows = false;
            this.passangersDataGridView.AllowUserToDeleteRows = false;
            this.passangersDataGridView.AutoGenerateColumns = false;
            this.passangersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.passangersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.passangersDataGridView.DataSource = this.passangersBindingSource;
            this.passangersDataGridView.Location = new System.Drawing.Point(6, 6);
            this.passangersDataGridView.Name = "passangersDataGridView";
            this.passangersDataGridView.ReadOnly = true;
            this.passangersDataGridView.Size = new System.Drawing.Size(663, 184);
            this.passangersDataGridView.TabIndex = 14;
            this.passangersDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.passangersDataGridView_RowHeaderMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PName";
            this.dataGridViewTextBoxColumn2.HeaderText = "PName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "PSurname";
            this.dataGridViewTextBoxColumn10.HeaderText = "PSurname";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Age";
            this.dataGridViewTextBoxColumn11.HeaderText = "Age";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Name";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(9, 209);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(103, 20);
            this.textBox6.TabIndex = 13;
            // 
            // insertPassanger
            // 
            this.insertPassanger.Location = new System.Drawing.Point(9, 235);
            this.insertPassanger.Name = "insertPassanger";
            this.insertPassanger.Size = new System.Drawing.Size(89, 25);
            this.insertPassanger.TabIndex = 11;
            this.insertPassanger.Text = "Insert";
            this.insertPassanger.UseVisualStyleBackColor = true;
            this.insertPassanger.Click += new System.EventHandler(this.insertPassanger_Click);
            // 
            // ticketsBindingSource1
            // 
            this.ticketsBindingSource1.DataMember = "Tickets";
            this.ticketsBindingSource1.DataSource = this.rgrDBDataSetBindingSource;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(503, 324);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(89, 25);
            this.update.TabIndex = 4;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(598, 325);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(89, 25);
            this.delete.TabIndex = 3;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // flightTableAdapter
            // 
            this.flightTableAdapter.ClearBeforeFill = true;
            // 
            // ticketsTableAdapter
            // 
            this.ticketsTableAdapter.ClearBeforeFill = true;
            // 
            // passangersTableAdapter
            // 
            this.passangersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FlightTableAdapter = this.flightTableAdapter;
            this.tableAdapterManager.PassangersTableAdapter = this.passangersTableAdapter;
            this.tableAdapterManager.TicketsTableAdapter = this.ticketsTableAdapter;
            this.tableAdapterManager.UpdateOrder = rgr.rgrDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pNameDataGridViewTextBoxColumn1
            // 
            this.pNameDataGridViewTextBoxColumn1.DataPropertyName = "PName";
            this.pNameDataGridViewTextBoxColumn1.HeaderText = "PName";
            this.pNameDataGridViewTextBoxColumn1.Name = "pNameDataGridViewTextBoxColumn1";
            this.pNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pSurnameDataGridViewTextBoxColumn1
            // 
            this.pSurnameDataGridViewTextBoxColumn1.DataPropertyName = "PSurname";
            this.pSurnameDataGridViewTextBoxColumn1.HeaderText = "PSurname";
            this.pSurnameDataGridViewTextBoxColumn1.Name = "pSurnameDataGridViewTextBoxColumn1";
            this.pSurnameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn1
            // 
            this.ageDataGridViewTextBoxColumn1.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn1.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn1.Name = "ageDataGridViewTextBoxColumn1";
            this.ageDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 361);
            this.Controls.Add(this.tableTabs);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Database";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableTabs.ResumeLayout(false);
            this.tabPageFlights.ResumeLayout(false);
            this.tabPageFlights.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgrDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgrDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightSupportingGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passangersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource1)).EndInit();
            this.tabPageTickets.ResumeLayout(false);
            this.tabPageTickets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsPassangersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsFlightsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).EndInit();
            this.tabPagePassangers.ResumeLayout(false);
            this.tabPagePassangers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passangersSupportingGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passangersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource rgrDBDataSetBindingSource;
        private rgrDBDataSet rgrDBDataSet;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tableTabs;
        private System.Windows.Forms.TabPage tabPageFlights;
        private System.Windows.Forms.TabPage tabPageTickets;
        private System.Windows.Forms.TabPage tabPagePassangers;
        private System.Windows.Forms.BindingSource flightBindingSource;
        private rgrDBDataSetTableAdapters.FlightTableAdapter flightTableAdapter;
        private System.Windows.Forms.BindingSource ticketsBindingSource;
        private rgrDBDataSetTableAdapters.TicketsTableAdapter ticketsTableAdapter;
        private System.Windows.Forms.BindingSource passangersBindingSource;
        private rgrDBDataSetTableAdapters.PassangersTableAdapter passangersTableAdapter;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.BindingSource flightBindingSource1;
        private rgrDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button insertFlight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button insertTicket;
        private System.Windows.Forms.Button insertPassanger;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.DataGridView passangersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridView ticketsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.DataGridView flightSupportingGridView;
        private System.Windows.Forms.BindingSource ticketsBindingSource1;
        private System.Windows.Forms.DataGridView passangersSupportingGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.DataGridView flightDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Plane;
        private System.Windows.Forms.Button searchFlightButton;
        private System.Windows.Forms.Button searchTicketsButton;
        private System.Windows.Forms.Button searchPassangersButton;
        private System.Windows.Forms.ComboBox passangerIdComboBox;
        private System.Windows.Forms.ComboBox flightIdComboBox;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView ticketsPassangersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView ticketsFlightsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn planeDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passangersListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flightsInfoToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pSurnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn1;
    }
}

