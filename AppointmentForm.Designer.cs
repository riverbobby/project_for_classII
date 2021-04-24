
namespace JustinTownleySoftwareII
{
    partial class AppointmentForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.appointmentIdLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.contactLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.urlLabel = new System.Windows.Forms.Label();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.endTimeLabel = new System.Windows.Forms.Label();
            this.createdOnLabel = new System.Windows.Forms.Label();
            this.createdByLabel = new System.Windows.Forms.Label();
            this.updatedByLabel = new System.Windows.Forms.Label();
            this.lastUpdateOnLabel = new System.Windows.Forms.Label();
            this.appointmentIdTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.updateCustomerButton = new System.Windows.Forms.Button();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.userIdComboBox = new System.Windows.Forms.ComboBox();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(335, 610);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(136, 58);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(97, 610);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(136, 58);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // appointmentIdLabel
            // 
            this.appointmentIdLabel.AutoSize = true;
            this.appointmentIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentIdLabel.Location = new System.Drawing.Point(37, 28);
            this.appointmentIdLabel.Name = "appointmentIdLabel";
            this.appointmentIdLabel.Size = new System.Drawing.Size(121, 20);
            this.appointmentIdLabel.TabIndex = 9;
            this.appointmentIdLabel.Text = "Appointment ID";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.Location = new System.Drawing.Point(80, 66);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(78, 20);
            this.customerLabel.TabIndex = 10;
            this.customerLabel.Text = "Customer";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(120, 159);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(38, 20);
            this.titleLabel.TabIndex = 11;
            this.titleLabel.Text = "Title";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(69, 204);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(89, 20);
            this.descriptionLabel.TabIndex = 12;
            this.descriptionLabel.Text = "Description";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.Location = new System.Drawing.Point(88, 243);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(70, 20);
            this.locationLabel.TabIndex = 13;
            this.locationLabel.Text = "Location";
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLabel.Location = new System.Drawing.Point(93, 285);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(65, 20);
            this.contactLabel.TabIndex = 14;
            this.contactLabel.Text = "Contact";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(115, 327);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(43, 20);
            this.typeLabel.TabIndex = 15;
            this.typeLabel.Text = "Type";
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlLabel.Location = new System.Drawing.Point(115, 368);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(42, 20);
            this.urlLabel.TabIndex = 16;
            this.urlLabel.Text = "URL";
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimeLabel.Location = new System.Drawing.Point(76, 404);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(82, 20);
            this.startTimeLabel.TabIndex = 17;
            this.startTimeLabel.Text = "Start Time";
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTimeLabel.Location = new System.Drawing.Point(82, 444);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(76, 20);
            this.endTimeLabel.TabIndex = 18;
            this.endTimeLabel.Text = "End Time";
            // 
            // createdOnLabel
            // 
            this.createdOnLabel.AutoSize = true;
            this.createdOnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdOnLabel.Location = new System.Drawing.Point(37, 497);
            this.createdOnLabel.Name = "createdOnLabel";
            this.createdOnLabel.Size = new System.Drawing.Size(0, 20);
            this.createdOnLabel.TabIndex = 19;
            // 
            // createdByLabel
            // 
            this.createdByLabel.AutoSize = true;
            this.createdByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdByLabel.Location = new System.Drawing.Point(392, 497);
            this.createdByLabel.Name = "createdByLabel";
            this.createdByLabel.Size = new System.Drawing.Size(0, 20);
            this.createdByLabel.TabIndex = 20;
            // 
            // updatedByLabel
            // 
            this.updatedByLabel.AutoSize = true;
            this.updatedByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatedByLabel.Location = new System.Drawing.Point(392, 551);
            this.updatedByLabel.Name = "updatedByLabel";
            this.updatedByLabel.Size = new System.Drawing.Size(0, 20);
            this.updatedByLabel.TabIndex = 22;
            // 
            // lastUpdateOnLabel
            // 
            this.lastUpdateOnLabel.AutoSize = true;
            this.lastUpdateOnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastUpdateOnLabel.Location = new System.Drawing.Point(37, 551);
            this.lastUpdateOnLabel.Name = "lastUpdateOnLabel";
            this.lastUpdateOnLabel.Size = new System.Drawing.Size(0, 20);
            this.lastUpdateOnLabel.TabIndex = 21;
            // 
            // appointmentIdTextBox
            // 
            this.appointmentIdTextBox.Location = new System.Drawing.Point(193, 30);
            this.appointmentIdTextBox.Name = "appointmentIdTextBox";
            this.appointmentIdTextBox.ReadOnly = true;
            this.appointmentIdTextBox.Size = new System.Drawing.Size(359, 20);
            this.appointmentIdTextBox.TabIndex = 23;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(193, 161);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(359, 20);
            this.titleTextBox.TabIndex = 25;
            this.titleTextBox.Text = "not needed";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(193, 206);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(359, 20);
            this.descriptionTextBox.TabIndex = 26;
            this.descriptionTextBox.Text = "not needed";
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(193, 245);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(359, 20);
            this.locationTextBox.TabIndex = 27;
            this.locationTextBox.Text = "not needed";
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(193, 287);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(359, 20);
            this.contactTextBox.TabIndex = 28;
            this.contactTextBox.Text = "not needed";
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(193, 329);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(359, 20);
            this.typeTextBox.TabIndex = 29;
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(193, 368);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(359, 20);
            this.urlTextBox.TabIndex = 30;
            this.urlTextBox.Text = "not needed";
            // 
            // startDatePicker
            // 
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDatePicker.Location = new System.Drawing.Point(193, 403);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(96, 20);
            this.startDatePicker.TabIndex = 31;
            // 
            // endDatePicker
            // 
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDatePicker.Location = new System.Drawing.Point(193, 444);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(96, 20);
            this.endDatePicker.TabIndex = 32;
            // 
            // startTimePicker
            // 
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startTimePicker.Location = new System.Drawing.Point(318, 404);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.Size = new System.Drawing.Size(94, 20);
            this.startTimePicker.TabIndex = 33;
            // 
            // endTimePicker
            // 
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endTimePicker.Location = new System.Drawing.Point(318, 443);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.Size = new System.Drawing.Size(94, 20);
            this.endTimePicker.TabIndex = 34;
            // 
            // customerComboBox
            // 
            this.customerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(193, 68);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(197, 21);
            this.customerComboBox.TabIndex = 35;
            // 
            // updateCustomerButton
            // 
            this.updateCustomerButton.Location = new System.Drawing.Point(396, 68);
            this.updateCustomerButton.Name = "updateCustomerButton";
            this.updateCustomerButton.Size = new System.Drawing.Size(75, 23);
            this.updateCustomerButton.TabIndex = 36;
            this.updateCustomerButton.Text = "update";
            this.updateCustomerButton.UseVisualStyleBackColor = true;
            this.updateCustomerButton.Click += new System.EventHandler(this.updateCustomerButton_Click);
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.Location = new System.Drawing.Point(477, 68);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(75, 23);
            this.addCustomerButton.TabIndex = 37;
            this.addCustomerButton.Text = "add new";
            this.addCustomerButton.UseVisualStyleBackColor = true;
            this.addCustomerButton.Click += new System.EventHandler(this.addCustomerButton_Click);
            // 
            // userIdComboBox
            // 
            this.userIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userIdComboBox.FormattingEnabled = true;
            this.userIdComboBox.Location = new System.Drawing.Point(193, 114);
            this.userIdComboBox.Name = "userIdComboBox";
            this.userIdComboBox.Size = new System.Drawing.Size(359, 21);
            this.userIdComboBox.TabIndex = 39;
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdLabel.Location = new System.Drawing.Point(94, 112);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(64, 20);
            this.userIdLabel.TabIndex = 38;
            this.userIdLabel.Text = "User ID";
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 745);
            this.Controls.Add(this.userIdComboBox);
            this.Controls.Add(this.userIdLabel);
            this.Controls.Add(this.addCustomerButton);
            this.Controls.Add(this.updateCustomerButton);
            this.Controls.Add(this.customerComboBox);
            this.Controls.Add(this.endTimePicker);
            this.Controls.Add(this.startTimePicker);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.appointmentIdTextBox);
            this.Controls.Add(this.updatedByLabel);
            this.Controls.Add(this.lastUpdateOnLabel);
            this.Controls.Add(this.createdByLabel);
            this.Controls.Add(this.createdOnLabel);
            this.Controls.Add(this.endTimeLabel);
            this.Controls.Add(this.startTimeLabel);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.contactLabel);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.appointmentIdLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Name = "AppointmentForm";
            this.Text = "Appointment Form";
            this.VisibleChanged += new System.EventHandler(this.AppointmentForm_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label appointmentIdLabel;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.Label endTimeLabel;
        private System.Windows.Forms.Label createdOnLabel;
        private System.Windows.Forms.Label createdByLabel;
        private System.Windows.Forms.Label updatedByLabel;
        private System.Windows.Forms.Label lastUpdateOnLabel;
        private System.Windows.Forms.TextBox appointmentIdTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.Button updateCustomerButton;
        private System.Windows.Forms.Button addCustomerButton;
        private System.Windows.Forms.ComboBox userIdComboBox;
        private System.Windows.Forms.Label userIdLabel;
    }
}