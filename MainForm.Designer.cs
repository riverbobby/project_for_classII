
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
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.displayTitleLabel = new System.Windows.Forms.Label();
            this.customersButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.allAppointmentsButton = new System.Windows.Forms.Button();
            this.consultantButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.report1Button = new System.Windows.Forms.Button();
            this.report2Button = new System.Windows.Forms.Button();
            this.report3Button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.weekButton = new System.Windows.Forms.Button();
            this.monthButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.displayDataGridView)).BeginInit();
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
            this.displayDataGridView.MultiSelect = false;
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
            this.addButton.Size = new System.Drawing.Size(189, 58);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add New\r\nCustomer";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Enabled = false;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(478, 741);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(178, 58);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "Edit\r\nSelection";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(681, 741);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(157, 58);
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
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(105, 245);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 21);
            this.comboBox.TabIndex = 2;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(105, 344);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(75, 20);
            this.dateTimePicker.TabIndex = 15;
            // 
            // displayTitleLabel
            // 
            this.displayTitleLabel.AutoSize = true;
            this.displayTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTitleLabel.Location = new System.Drawing.Point(259, 9);
            this.displayTitleLabel.Name = "displayTitleLabel";
            this.displayTitleLabel.Size = new System.Drawing.Size(128, 37);
            this.displayTitleLabel.TabIndex = 15;
            this.displayTitleLabel.Text = "Display";
            // 
            // customersButton
            // 
            this.customersButton.Location = new System.Drawing.Point(46, 88);
            this.customersButton.Name = "customersButton";
            this.customersButton.Size = new System.Drawing.Size(148, 34);
            this.customersButton.TabIndex = 16;
            this.customersButton.Text = "all customers";
            this.customersButton.UseVisualStyleBackColor = true;
            this.customersButton.Click += new System.EventHandler(this.customersButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Display Customers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Display Appointments";
            // 
            // allAppointmentsButton
            // 
            this.allAppointmentsButton.Location = new System.Drawing.Point(46, 165);
            this.allAppointmentsButton.Name = "allAppointmentsButton";
            this.allAppointmentsButton.Size = new System.Drawing.Size(148, 34);
            this.allAppointmentsButton.TabIndex = 19;
            this.allAppointmentsButton.Text = "all appointments";
            this.allAppointmentsButton.UseVisualStyleBackColor = true;
            this.allAppointmentsButton.Click += new System.EventHandler(this.allAppointmentsButton_Click);
            // 
            // consultantButton
            // 
            this.consultantButton.Location = new System.Drawing.Point(46, 205);
            this.consultantButton.Name = "consultantButton";
            this.consultantButton.Size = new System.Drawing.Size(148, 34);
            this.consultantButton.TabIndex = 20;
            this.consultantButton.Text = "by consultant";
            this.consultantButton.UseVisualStyleBackColor = true;
            this.consultantButton.Click += new System.EventHandler(this.consultantButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Display Report";
            // 
            // report1Button
            // 
            this.report1Button.Location = new System.Drawing.Point(46, 304);
            this.report1Button.Name = "report1Button";
            this.report1Button.Size = new System.Drawing.Size(148, 34);
            this.report1Button.TabIndex = 22;
            this.report1Button.Text = "number of appointment\r\ntypes by month";
            this.report1Button.UseVisualStyleBackColor = true;
            this.report1Button.Click += new System.EventHandler(this.report1Button_Click);
            // 
            // report2Button
            // 
            this.report2Button.Location = new System.Drawing.Point(46, 370);
            this.report2Button.Name = "report2Button";
            this.report2Button.Size = new System.Drawing.Size(148, 34);
            this.report2Button.TabIndex = 23;
            this.report2Button.Text = "upcoming appointments";
            this.report2Button.UseVisualStyleBackColor = true;
            this.report2Button.Click += new System.EventHandler(this.report2Button_Click);
            // 
            // report3Button
            // 
            this.report3Button.Location = new System.Drawing.Point(46, 410);
            this.report3Button.Name = "report3Button";
            this.report3Button.Size = new System.Drawing.Size(148, 34);
            this.report3Button.TabIndex = 24;
            this.report3Button.Text = "past appointments";
            this.report3Button.UseVisualStyleBackColor = true;
            this.report3Button.Click += new System.EventHandler(this.report3Button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Display Calendar";
            // 
            // weekButton
            // 
            this.weekButton.Location = new System.Drawing.Point(46, 481);
            this.weekButton.Name = "weekButton";
            this.weekButton.Size = new System.Drawing.Size(148, 34);
            this.weekButton.TabIndex = 26;
            this.weekButton.Text = "view by week";
            this.weekButton.UseVisualStyleBackColor = true;
            this.weekButton.Click += new System.EventHandler(this.weekButton_Click);
            // 
            // monthButton
            // 
            this.monthButton.Location = new System.Drawing.Point(46, 521);
            this.monthButton.Name = "monthButton";
            this.monthButton.Size = new System.Drawing.Size(148, 34);
            this.monthButton.TabIndex = 27;
            this.monthButton.Text = "view by month";
            this.monthButton.UseVisualStyleBackColor = true;
            this.monthButton.Click += new System.EventHandler(this.monthButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 811);
            this.Controls.Add(this.monthButton);
            this.Controls.Add(this.weekButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.report3Button);
            this.Controls.Add(this.report2Button);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.report1Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.consultantButton);
            this.Controls.Add(this.allAppointmentsButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customersButton);
            this.Controls.Add(this.displayTitleLabel);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.displayDataGridView);
            this.Controls.Add(this.logOutButton);
            this.Name = "MainForm";
            this.Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)(this.displayDataGridView)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label displayTitleLabel;
        private System.Windows.Forms.Button customersButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button allAppointmentsButton;
        private System.Windows.Forms.Button consultantButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button report1Button;
        private System.Windows.Forms.Button report2Button;
        private System.Windows.Forms.Button report3Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button weekButton;
        private System.Windows.Forms.Button monthButton;
    }
}