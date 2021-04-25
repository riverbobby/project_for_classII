
namespace JustinTownleySoftwareII
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.logOutButton = new System.Windows.Forms.Button();
            this.displayDataGridView = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.calendarMonthRadioButton = new System.Windows.Forms.RadioButton();
            this.calendarWeekRadioButton = new System.Windows.Forms.RadioButton();
            this.calendarRadioButton = new System.Windows.Forms.RadioButton();
            this.customersRadioButton = new System.Windows.Forms.RadioButton();
            this.appointmentsRadioButton = new System.Windows.Forms.RadioButton();
            this.reportRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.appointments2RadioButton = new System.Windows.Forms.RadioButton();
            this.appointments1RadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.report3RadioButton = new System.Windows.Forms.RadioButton();
            this.report1RadioButton = new System.Windows.Forms.RadioButton();
            this.report2RadioButton = new System.Windows.Forms.RadioButton();
            this.displayTitleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.displayDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // logOutButton
            // 
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(1124, 741);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(136, 58);
            this.logOutButton.TabIndex = 2;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // displayDataGridView
            // 
            this.displayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayDataGridView.Location = new System.Drawing.Point(266, 68);
            this.displayDataGridView.Name = "displayDataGridView";
            this.displayDataGridView.ReadOnly = true;
            this.displayDataGridView.Size = new System.Drawing.Size(994, 658);
            this.displayDataGridView.TabIndex = 3;
            this.displayDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.displayDataGridView_CellClick);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(266, 741);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(136, 58);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add New\r\nCustomer";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Enabled = false;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(432, 741);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(136, 58);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "Edit\r\nSelection";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(600, 741);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(136, 58);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete\r\nSelection";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(18, 564);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 7;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.calendarMonthRadioButton);
            this.groupBox1.Controls.Add(this.calendarWeekRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(123, 514);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 51);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "view by";
            // 
            // calendarMonthRadioButton
            // 
            this.calendarMonthRadioButton.AutoSize = true;
            this.calendarMonthRadioButton.Location = new System.Drawing.Point(63, 19);
            this.calendarMonthRadioButton.Name = "calendarMonthRadioButton";
            this.calendarMonthRadioButton.Size = new System.Drawing.Size(54, 17);
            this.calendarMonthRadioButton.TabIndex = 1;
            this.calendarMonthRadioButton.Text = "month";
            this.calendarMonthRadioButton.UseVisualStyleBackColor = true;
            this.calendarMonthRadioButton.CheckedChanged += new System.EventHandler(this.calendarRadioButton_CheckedChanged);
            // 
            // calendarWeekRadioButton
            // 
            this.calendarWeekRadioButton.AutoSize = true;
            this.calendarWeekRadioButton.Checked = true;
            this.calendarWeekRadioButton.Location = new System.Drawing.Point(6, 19);
            this.calendarWeekRadioButton.Name = "calendarWeekRadioButton";
            this.calendarWeekRadioButton.Size = new System.Drawing.Size(51, 17);
            this.calendarWeekRadioButton.TabIndex = 0;
            this.calendarWeekRadioButton.TabStop = true;
            this.calendarWeekRadioButton.Text = "week";
            this.calendarWeekRadioButton.UseVisualStyleBackColor = true;
            this.calendarWeekRadioButton.CheckedChanged += new System.EventHandler(this.calendarRadioButton_CheckedChanged);
            // 
            // calendarRadioButton
            // 
            this.calendarRadioButton.AutoSize = true;
            this.calendarRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarRadioButton.Location = new System.Drawing.Point(18, 484);
            this.calendarRadioButton.Name = "calendarRadioButton";
            this.calendarRadioButton.Size = new System.Drawing.Size(162, 24);
            this.calendarRadioButton.TabIndex = 9;
            this.calendarRadioButton.Text = "Display Calendar";
            this.calendarRadioButton.UseVisualStyleBackColor = true;
            this.calendarRadioButton.CheckedChanged += new System.EventHandler(this.calendarRadioButton_CheckedChanged);
            // 
            // customersRadioButton
            // 
            this.customersRadioButton.AutoSize = true;
            this.customersRadioButton.Checked = true;
            this.customersRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersRadioButton.Location = new System.Drawing.Point(18, 68);
            this.customersRadioButton.Name = "customersRadioButton";
            this.customersRadioButton.Size = new System.Drawing.Size(176, 24);
            this.customersRadioButton.TabIndex = 10;
            this.customersRadioButton.TabStop = true;
            this.customersRadioButton.Text = "Display Customers";
            this.customersRadioButton.UseVisualStyleBackColor = true;
            this.customersRadioButton.CheckedChanged += new System.EventHandler(this.customersRadioButton_CheckedChanged);
            // 
            // appointmentsRadioButton
            // 
            this.appointmentsRadioButton.AutoSize = true;
            this.appointmentsRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentsRadioButton.Location = new System.Drawing.Point(18, 158);
            this.appointmentsRadioButton.Name = "appointmentsRadioButton";
            this.appointmentsRadioButton.Size = new System.Drawing.Size(201, 24);
            this.appointmentsRadioButton.TabIndex = 11;
            this.appointmentsRadioButton.Text = "Display Appointments";
            this.appointmentsRadioButton.UseVisualStyleBackColor = true;
            this.appointmentsRadioButton.CheckedChanged += new System.EventHandler(this.appointmentsRadioButton_CheckedChanged);
            // 
            // reportRadioButton
            // 
            this.reportRadioButton.AutoSize = true;
            this.reportRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportRadioButton.Location = new System.Drawing.Point(18, 304);
            this.reportRadioButton.Name = "reportRadioButton";
            this.reportRadioButton.Size = new System.Drawing.Size(145, 24);
            this.reportRadioButton.TabIndex = 12;
            this.reportRadioButton.Text = "Display Report";
            this.reportRadioButton.UseVisualStyleBackColor = true;
            this.reportRadioButton.CheckedChanged += new System.EventHandler(this.reportRadioButton_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox);
            this.groupBox2.Controls.Add(this.appointments2RadioButton);
            this.groupBox2.Controls.Add(this.appointments1RadioButton);
            this.groupBox2.Location = new System.Drawing.Point(87, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(153, 110);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "view";
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(18, 65);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 21);
            this.comboBox.TabIndex = 2;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.appointmentsRadioButton_CheckedChanged);
            // 
            // appointments2RadioButton
            // 
            this.appointments2RadioButton.AutoSize = true;
            this.appointments2RadioButton.Location = new System.Drawing.Point(5, 42);
            this.appointments2RadioButton.Name = "appointments2RadioButton";
            this.appointments2RadioButton.Size = new System.Drawing.Size(88, 17);
            this.appointments2RadioButton.TabIndex = 1;
            this.appointments2RadioButton.Text = "by consultant";
            this.appointments2RadioButton.UseVisualStyleBackColor = true;
            this.appointments2RadioButton.CheckedChanged += new System.EventHandler(this.appointmentsRadioButton_CheckedChanged);
            // 
            // appointments1RadioButton
            // 
            this.appointments1RadioButton.AutoSize = true;
            this.appointments1RadioButton.Checked = true;
            this.appointments1RadioButton.Location = new System.Drawing.Point(6, 19);
            this.appointments1RadioButton.Name = "appointments1RadioButton";
            this.appointments1RadioButton.Size = new System.Drawing.Size(101, 17);
            this.appointments1RadioButton.TabIndex = 0;
            this.appointments1RadioButton.TabStop = true;
            this.appointments1RadioButton.Text = "all appointments";
            this.appointments1RadioButton.UseVisualStyleBackColor = true;
            this.appointments1RadioButton.CheckedChanged += new System.EventHandler(this.appointmentsRadioButton_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTimePicker);
            this.groupBox3.Controls.Add(this.report3RadioButton);
            this.groupBox3.Controls.Add(this.report1RadioButton);
            this.groupBox3.Controls.Add(this.report2RadioButton);
            this.groupBox3.Location = new System.Drawing.Point(87, 334);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(153, 144);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "view";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(64, 55);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(75, 20);
            this.dateTimePicker.TabIndex = 15;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.reportRadioButton_CheckedChanged);
            // 
            // report3RadioButton
            // 
            this.report3RadioButton.AutoSize = true;
            this.report3RadioButton.Location = new System.Drawing.Point(5, 104);
            this.report3RadioButton.Name = "report3RadioButton";
            this.report3RadioButton.Size = new System.Drawing.Size(108, 17);
            this.report3RadioButton.TabIndex = 3;
            this.report3RadioButton.Text = "past appoinments";
            this.report3RadioButton.UseVisualStyleBackColor = true;
            this.report3RadioButton.CheckedChanged += new System.EventHandler(this.reportRadioButton_CheckedChanged);
            // 
            // report1RadioButton
            // 
            this.report1RadioButton.AutoSize = true;
            this.report1RadioButton.Checked = true;
            this.report1RadioButton.Location = new System.Drawing.Point(6, 19);
            this.report1RadioButton.Name = "report1RadioButton";
            this.report1RadioButton.Size = new System.Drawing.Size(133, 30);
            this.report1RadioButton.TabIndex = 1;
            this.report1RadioButton.TabStop = true;
            this.report1RadioButton.Text = "number of appointment\r\ntypes by month";
            this.report1RadioButton.UseVisualStyleBackColor = true;
            this.report1RadioButton.CheckedChanged += new System.EventHandler(this.reportRadioButton_CheckedChanged);
            // 
            // report2RadioButton
            // 
            this.report2RadioButton.AutoSize = true;
            this.report2RadioButton.Location = new System.Drawing.Point(5, 81);
            this.report2RadioButton.Name = "report2RadioButton";
            this.report2RadioButton.Size = new System.Drawing.Size(137, 17);
            this.report2RadioButton.TabIndex = 0;
            this.report2RadioButton.Text = "upcoming appointments";
            this.report2RadioButton.UseVisualStyleBackColor = true;
            this.report2RadioButton.CheckedChanged += new System.EventHandler(this.reportRadioButton_CheckedChanged);
            // 
            // displayTitleLabel
            // 
            this.displayTitleLabel.AutoSize = true;
            this.displayTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTitleLabel.Location = new System.Drawing.Point(259, 9);
            this.displayTitleLabel.Name = "displayTitleLabel";
            this.displayTitleLabel.Size = new System.Drawing.Size(230, 37);
            this.displayTitleLabel.TabIndex = 15;
            this.displayTitleLabel.Text = "All Customers";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 811);
            this.Controls.Add(this.displayTitleLabel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.reportRadioButton);
            this.Controls.Add(this.appointmentsRadioButton);
            this.Controls.Add(this.customersRadioButton);
            this.Controls.Add(this.calendarRadioButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.displayDataGridView);
            this.Controls.Add(this.logOutButton);
            this.Name = "MainForm";
            this.Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)(this.displayDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.DataGridView displayDataGridView;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton calendarMonthRadioButton;
        private System.Windows.Forms.RadioButton calendarWeekRadioButton;
        private System.Windows.Forms.RadioButton calendarRadioButton;
        private System.Windows.Forms.RadioButton customersRadioButton;
        private System.Windows.Forms.RadioButton appointmentsRadioButton;
        private System.Windows.Forms.RadioButton reportRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.RadioButton appointments2RadioButton;
        private System.Windows.Forms.RadioButton appointments1RadioButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton report3RadioButton;
        private System.Windows.Forms.RadioButton report1RadioButton;
        private System.Windows.Forms.RadioButton report2RadioButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label displayTitleLabel;
    }
}