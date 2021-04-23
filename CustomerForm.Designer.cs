
namespace JustinTownleySoftwareII
{
    partial class CustomerForm
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
            this.addAddressButton = new System.Windows.Forms.Button();
            this.updateAddressButton = new System.Windows.Forms.Button();
            this.addressComboBox = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.customerIdTextBox = new System.Windows.Forms.TextBox();
            this.updatedByLabel = new System.Windows.Forms.Label();
            this.lastUpdateOnLabel = new System.Windows.Forms.Label();
            this.createdByLabel = new System.Windows.Forms.Label();
            this.createdOnLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.customerIdLabel = new System.Windows.Forms.Label();
            this.activeLabel = new System.Windows.Forms.Label();
            this.activeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(287, 300);
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
            this.saveButton.Location = new System.Drawing.Point(116, 300);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(136, 58);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // addAddressButton
            // 
            this.addAddressButton.Location = new System.Drawing.Point(459, 101);
            this.addAddressButton.Name = "addAddressButton";
            this.addAddressButton.Size = new System.Drawing.Size(75, 23);
            this.addAddressButton.TabIndex = 65;
            this.addAddressButton.Text = "add new";
            this.addAddressButton.UseVisualStyleBackColor = true;
            this.addAddressButton.Click += new System.EventHandler(this.addAddressButton_Click);
            // 
            // updateAddressButton
            // 
            this.updateAddressButton.Location = new System.Drawing.Point(378, 101);
            this.updateAddressButton.Name = "updateAddressButton";
            this.updateAddressButton.Size = new System.Drawing.Size(75, 23);
            this.updateAddressButton.TabIndex = 64;
            this.updateAddressButton.Text = "update";
            this.updateAddressButton.UseVisualStyleBackColor = true;
            this.updateAddressButton.Click += new System.EventHandler(this.updateAddressButton_Click);
            // 
            // addressComboBox
            // 
            this.addressComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addressComboBox.FormattingEnabled = true;
            this.addressComboBox.Location = new System.Drawing.Point(175, 101);
            this.addressComboBox.Name = "addressComboBox";
            this.addressComboBox.Size = new System.Drawing.Size(197, 21);
            this.addressComboBox.TabIndex = 63;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(175, 65);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(359, 20);
            this.nameTextBox.TabIndex = 53;
            // 
            // customerIdTextBox
            // 
            this.customerIdTextBox.Location = new System.Drawing.Point(175, 22);
            this.customerIdTextBox.Name = "customerIdTextBox";
            this.customerIdTextBox.ReadOnly = true;
            this.customerIdTextBox.Size = new System.Drawing.Size(359, 20);
            this.customerIdTextBox.TabIndex = 52;
            // 
            // updatedByLabel
            // 
            this.updatedByLabel.AutoSize = true;
            this.updatedByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatedByLabel.Location = new System.Drawing.Point(343, 245);
            this.updatedByLabel.Name = "updatedByLabel";
            this.updatedByLabel.Size = new System.Drawing.Size(0, 20);
            this.updatedByLabel.TabIndex = 51;
            // 
            // lastUpdateOnLabel
            // 
            this.lastUpdateOnLabel.AutoSize = true;
            this.lastUpdateOnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastUpdateOnLabel.Location = new System.Drawing.Point(56, 245);
            this.lastUpdateOnLabel.Name = "lastUpdateOnLabel";
            this.lastUpdateOnLabel.Size = new System.Drawing.Size(0, 20);
            this.lastUpdateOnLabel.TabIndex = 50;
            // 
            // createdByLabel
            // 
            this.createdByLabel.AutoSize = true;
            this.createdByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdByLabel.Location = new System.Drawing.Point(343, 191);
            this.createdByLabel.Name = "createdByLabel";
            this.createdByLabel.Size = new System.Drawing.Size(0, 20);
            this.createdByLabel.TabIndex = 49;
            // 
            // createdOnLabel
            // 
            this.createdOnLabel.AutoSize = true;
            this.createdOnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdOnLabel.Location = new System.Drawing.Point(56, 191);
            this.createdOnLabel.Name = "createdOnLabel";
            this.createdOnLabel.Size = new System.Drawing.Size(0, 20);
            this.createdOnLabel.TabIndex = 48;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(32, 102);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(118, 20);
            this.addressLabel.TabIndex = 40;
            this.addressLabel.Text = "Address/Phone";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(99, 63);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(51, 20);
            this.nameLabel.TabIndex = 39;
            this.nameLabel.Text = "Name";
            // 
            // customerIdLabel
            // 
            this.customerIdLabel.AutoSize = true;
            this.customerIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIdLabel.Location = new System.Drawing.Point(51, 22);
            this.customerIdLabel.Name = "customerIdLabel";
            this.customerIdLabel.Size = new System.Drawing.Size(99, 20);
            this.customerIdLabel.TabIndex = 38;
            this.customerIdLabel.Text = "Customer ID";
            // 
            // activeLabel
            // 
            this.activeLabel.AutoSize = true;
            this.activeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeLabel.Location = new System.Drawing.Point(98, 147);
            this.activeLabel.Name = "activeLabel";
            this.activeLabel.Size = new System.Drawing.Size(52, 20);
            this.activeLabel.TabIndex = 41;
            this.activeLabel.Text = "Active";
            // 
            // activeComboBox
            // 
            this.activeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activeComboBox.FormattingEnabled = true;
            this.activeComboBox.Location = new System.Drawing.Point(175, 146);
            this.activeComboBox.Name = "activeComboBox";
            this.activeComboBox.Size = new System.Drawing.Size(197, 21);
            this.activeComboBox.TabIndex = 66;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 396);
            this.Controls.Add(this.activeComboBox);
            this.Controls.Add(this.addAddressButton);
            this.Controls.Add(this.updateAddressButton);
            this.Controls.Add(this.addressComboBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.customerIdTextBox);
            this.Controls.Add(this.updatedByLabel);
            this.Controls.Add(this.lastUpdateOnLabel);
            this.Controls.Add(this.createdByLabel);
            this.Controls.Add(this.createdOnLabel);
            this.Controls.Add(this.activeLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.customerIdLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.VisibleChanged += new System.EventHandler(this.CustomerForm_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button addAddressButton;
        private System.Windows.Forms.Button updateAddressButton;
        private System.Windows.Forms.ComboBox addressComboBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox customerIdTextBox;
        private System.Windows.Forms.Label updatedByLabel;
        private System.Windows.Forms.Label lastUpdateOnLabel;
        private System.Windows.Forms.Label createdByLabel;
        private System.Windows.Forms.Label createdOnLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label customerIdLabel;
        private System.Windows.Forms.Label activeLabel;
        private System.Windows.Forms.ComboBox activeComboBox;
    }
}