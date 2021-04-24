
namespace JustinTownleySoftwareII
{
    partial class AddressForm
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
            this.addCityButton = new System.Windows.Forms.Button();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.addressIdTextBox = new System.Windows.Forms.TextBox();
            this.updatedByLabel = new System.Windows.Forms.Label();
            this.lastUpdateOnLabel = new System.Windows.Forms.Label();
            this.createdByLabel = new System.Windows.Forms.Label();
            this.createdOnLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.postalCodeLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.address2Label = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressIdLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addCityButton
            // 
            this.addCityButton.Location = new System.Drawing.Point(440, 138);
            this.addCityButton.Name = "addCityButton";
            this.addCityButton.Size = new System.Drawing.Size(75, 23);
            this.addCityButton.TabIndex = 85;
            this.addCityButton.Text = "add new";
            this.addCityButton.UseVisualStyleBackColor = true;
            this.addCityButton.Click += new System.EventHandler(this.addCityButton_Click);
            // 
            // cityComboBox
            // 
            this.cityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(156, 138);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(278, 21);
            this.cityComboBox.TabIndex = 83;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(156, 220);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(359, 20);
            this.phoneTextBox.TabIndex = 82;
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.Location = new System.Drawing.Point(156, 178);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(359, 20);
            this.postalCodeTextBox.TabIndex = 81;
            // 
            // address2TextBox
            // 
            this.address2TextBox.Location = new System.Drawing.Point(156, 94);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(359, 20);
            this.address2TextBox.TabIndex = 80;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(156, 57);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(359, 20);
            this.addressTextBox.TabIndex = 79;
            // 
            // addressIdTextBox
            // 
            this.addressIdTextBox.Location = new System.Drawing.Point(156, 14);
            this.addressIdTextBox.Name = "addressIdTextBox";
            this.addressIdTextBox.ReadOnly = true;
            this.addressIdTextBox.Size = new System.Drawing.Size(359, 20);
            this.addressIdTextBox.TabIndex = 78;
            // 
            // updatedByLabel
            // 
            this.updatedByLabel.AutoSize = true;
            this.updatedByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatedByLabel.Location = new System.Drawing.Point(343, 324);
            this.updatedByLabel.Name = "updatedByLabel";
            this.updatedByLabel.Size = new System.Drawing.Size(0, 20);
            this.updatedByLabel.TabIndex = 77;
            // 
            // lastUpdateOnLabel
            // 
            this.lastUpdateOnLabel.AutoSize = true;
            this.lastUpdateOnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastUpdateOnLabel.Location = new System.Drawing.Point(32, 324);
            this.lastUpdateOnLabel.Name = "lastUpdateOnLabel";
            this.lastUpdateOnLabel.Size = new System.Drawing.Size(0, 20);
            this.lastUpdateOnLabel.TabIndex = 76;
            // 
            // createdByLabel
            // 
            this.createdByLabel.AutoSize = true;
            this.createdByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdByLabel.Location = new System.Drawing.Point(343, 270);
            this.createdByLabel.Name = "createdByLabel";
            this.createdByLabel.Size = new System.Drawing.Size(0, 20);
            this.createdByLabel.TabIndex = 75;
            // 
            // createdOnLabel
            // 
            this.createdOnLabel.AutoSize = true;
            this.createdOnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdOnLabel.Location = new System.Drawing.Point(32, 270);
            this.createdOnLabel.Name = "createdOnLabel";
            this.createdOnLabel.Size = new System.Drawing.Size(0, 20);
            this.createdOnLabel.TabIndex = 74;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(16, 220);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(115, 20);
            this.phoneLabel.TabIndex = 73;
            this.phoneLabel.Text = "Phone Number";
            // 
            // postalCodeLabel
            // 
            this.postalCodeLabel.AutoSize = true;
            this.postalCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postalCodeLabel.Location = new System.Drawing.Point(36, 178);
            this.postalCodeLabel.Name = "postalCodeLabel";
            this.postalCodeLabel.Size = new System.Drawing.Size(95, 20);
            this.postalCodeLabel.TabIndex = 72;
            this.postalCodeLabel.Text = "Postal Code";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(96, 136);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(35, 20);
            this.cityLabel.TabIndex = 71;
            this.cityLabel.Text = "City";
            // 
            // address2Label
            // 
            this.address2Label.AutoSize = true;
            this.address2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address2Label.Location = new System.Drawing.Point(50, 94);
            this.address2Label.Name = "address2Label";
            this.address2Label.Size = new System.Drawing.Size(81, 20);
            this.address2Label.TabIndex = 70;
            this.address2Label.Text = "Address 2";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(63, 57);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(68, 20);
            this.addressLabel.TabIndex = 69;
            this.addressLabel.Text = "Address";
            // 
            // addressIdLabel
            // 
            this.addressIdLabel.AutoSize = true;
            this.addressIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressIdLabel.Location = new System.Drawing.Point(42, 14);
            this.addressIdLabel.Name = "addressIdLabel";
            this.addressIdLabel.Size = new System.Drawing.Size(89, 20);
            this.addressIdLabel.TabIndex = 68;
            this.addressIdLabel.Text = "Address ID";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(92, 379);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(136, 58);
            this.saveButton.TabIndex = 67;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(263, 379);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(136, 58);
            this.cancelButton.TabIndex = 66;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 467);
            this.Controls.Add(this.addCityButton);
            this.Controls.Add(this.cityComboBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.postalCodeTextBox);
            this.Controls.Add(this.address2TextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.addressIdTextBox);
            this.Controls.Add(this.updatedByLabel);
            this.Controls.Add(this.lastUpdateOnLabel);
            this.Controls.Add(this.createdByLabel);
            this.Controls.Add(this.createdOnLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.postalCodeLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.address2Label);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.addressIdLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Name = "AddressForm";
            this.Text = "Address Form";
            this.VisibleChanged += new System.EventHandler(this.AddressForm_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addCityButton;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox addressIdTextBox;
        private System.Windows.Forms.Label updatedByLabel;
        private System.Windows.Forms.Label lastUpdateOnLabel;
        private System.Windows.Forms.Label createdByLabel;
        private System.Windows.Forms.Label createdOnLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label postalCodeLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label address2Label;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label addressIdLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}