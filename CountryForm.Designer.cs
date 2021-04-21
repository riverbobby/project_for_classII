
namespace JustinTownleySoftwareII
{
    partial class CountryForm
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
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.countryIdTextBox = new System.Windows.Forms.TextBox();
            this.updatedByLabel = new System.Windows.Forms.Label();
            this.LastUpdateOnLabel = new System.Windows.Forms.Label();
            this.createdByLabel = new System.Windows.Forms.Label();
            this.createdOnLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.countryIdLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(156, 53);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(359, 20);
            this.countryTextBox.TabIndex = 79;
            // 
            // countryIdTextBox
            // 
            this.countryIdTextBox.Location = new System.Drawing.Point(156, 10);
            this.countryIdTextBox.Name = "countryIdTextBox";
            this.countryIdTextBox.ReadOnly = true;
            this.countryIdTextBox.Size = new System.Drawing.Size(359, 20);
            this.countryIdTextBox.TabIndex = 78;
            // 
            // updatedByLabel
            // 
            this.updatedByLabel.AutoSize = true;
            this.updatedByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatedByLabel.Location = new System.Drawing.Point(217, 152);
            this.updatedByLabel.Name = "updatedByLabel";
            this.updatedByLabel.Size = new System.Drawing.Size(16, 20);
            this.updatedByLabel.TabIndex = 77;
            this.updatedByLabel.Text = "x";
            // 
            // LastUpdateOnLabel
            // 
            this.LastUpdateOnLabel.AutoSize = true;
            this.LastUpdateOnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastUpdateOnLabel.Location = new System.Drawing.Point(37, 152);
            this.LastUpdateOnLabel.Name = "LastUpdateOnLabel";
            this.LastUpdateOnLabel.Size = new System.Drawing.Size(16, 20);
            this.LastUpdateOnLabel.TabIndex = 76;
            this.LastUpdateOnLabel.Text = "x";
            // 
            // createdByLabel
            // 
            this.createdByLabel.AutoSize = true;
            this.createdByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdByLabel.Location = new System.Drawing.Point(217, 98);
            this.createdByLabel.Name = "createdByLabel";
            this.createdByLabel.Size = new System.Drawing.Size(16, 20);
            this.createdByLabel.TabIndex = 75;
            this.createdByLabel.Text = "x";
            // 
            // createdOnLabel
            // 
            this.createdOnLabel.AutoSize = true;
            this.createdOnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdOnLabel.Location = new System.Drawing.Point(37, 98);
            this.createdOnLabel.Name = "createdOnLabel";
            this.createdOnLabel.Size = new System.Drawing.Size(16, 20);
            this.createdOnLabel.TabIndex = 74;
            this.createdOnLabel.Text = "x";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel.Location = new System.Drawing.Point(80, 51);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(64, 20);
            this.countryLabel.TabIndex = 69;
            this.countryLabel.Text = "Country";
            // 
            // countryIdLabel
            // 
            this.countryIdLabel.AutoSize = true;
            this.countryIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryIdLabel.Location = new System.Drawing.Point(59, 10);
            this.countryIdLabel.Name = "countryIdLabel";
            this.countryIdLabel.Size = new System.Drawing.Size(85, 20);
            this.countryIdLabel.TabIndex = 68;
            this.countryIdLabel.Text = "Country ID";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(97, 207);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(136, 58);
            this.saveButton.TabIndex = 67;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(268, 207);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(136, 58);
            this.cancelButton.TabIndex = 66;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // CountryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 297);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.countryIdTextBox);
            this.Controls.Add(this.updatedByLabel);
            this.Controls.Add(this.LastUpdateOnLabel);
            this.Controls.Add(this.createdByLabel);
            this.Controls.Add(this.createdOnLabel);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.countryIdLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Name = "CountryForm";
            this.Text = "CountryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox countryIdTextBox;
        private System.Windows.Forms.Label updatedByLabel;
        private System.Windows.Forms.Label LastUpdateOnLabel;
        private System.Windows.Forms.Label createdByLabel;
        private System.Windows.Forms.Label createdOnLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label countryIdLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}