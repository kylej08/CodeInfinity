namespace Test1
{
    partial class HomeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.idNumberTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.postButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.idNumberErrorLabel = new System.Windows.Forms.Label();
            this.nameErrorLabel = new System.Windows.Forms.Label();
            this.surnameErrorLabel = new System.Windows.Forms.Label();
            this.dateOfBirthErrorLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(102, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // idNumberTextBox
            // 
            this.idNumberTextBox.Location = new System.Drawing.Point(186, 64);
            this.idNumberTextBox.MaxLength = 13;
            this.idNumberTextBox.Name = "idNumberTextBox";
            this.idNumberTextBox.Size = new System.Drawing.Size(137, 23);
            this.idNumberTextBox.TabIndex = 1;
            this.idNumberTextBox.TextChanged += new System.EventHandler(this.idNumberTextBox_TextChanged);
            this.idNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idNumberTextBox_KeyPress);
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.dateOfBirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(186, 174);
            this.dateOfBirthDateTimePicker.MaxDate = new System.DateTime(2006, 4, 1, 0, 0, 0, 0);
            this.dateOfBirthDateTimePicker.MinDate = new System.DateTime(1902, 1, 1, 0, 0, 0, 0);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.dateOfBirthDateTimePicker.TabIndex = 2;
            this.dateOfBirthDateTimePicker.Value = new System.DateTime(1902, 1, 1, 0, 0, 0, 0);
            this.dateOfBirthDateTimePicker.ValueChanged += new System.EventHandler(this.dateOfBirthDateTimePicker_ValueChanged);
            // 
            // postButton
            // 
            this.postButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.postButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.postButton.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.postButton.Location = new System.Drawing.Point(246, 270);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(75, 23);
            this.postButton.TabIndex = 3;
            this.postButton.Text = "Post";
            this.postButton.UseVisualStyleBackColor = false;
            this.postButton.Click += new System.EventHandler(this.postButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(186, 118);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(137, 23);
            this.nameTextBox.TabIndex = 5;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(98, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(431, 118);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(133, 23);
            this.surnameTextBox.TabIndex = 7;
            this.surnameTextBox.TextChanged += new System.EventHandler(this.surnameTextBox_TextChanged);
            this.surnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(363, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(98, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date of Birth";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Gold;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelButton.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.Location = new System.Drawing.Point(372, 270);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // idNumberErrorLabel
            // 
            this.idNumberErrorLabel.AutoSize = true;
            this.idNumberErrorLabel.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idNumberErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.idNumberErrorLabel.Location = new System.Drawing.Point(186, 90);
            this.idNumberErrorLabel.Name = "idNumberErrorLabel";
            this.idNumberErrorLabel.Size = new System.Drawing.Size(132, 16);
            this.idNumberErrorLabel.TabIndex = 10;
            this.idNumberErrorLabel.Text = "<error-placeholder>";
            this.idNumberErrorLabel.Visible = false;
            // 
            // nameErrorLabel
            // 
            this.nameErrorLabel.AutoSize = true;
            this.nameErrorLabel.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.nameErrorLabel.Location = new System.Drawing.Point(186, 144);
            this.nameErrorLabel.Name = "nameErrorLabel";
            this.nameErrorLabel.Size = new System.Drawing.Size(132, 16);
            this.nameErrorLabel.TabIndex = 11;
            this.nameErrorLabel.Text = "<error-placeholder>";
            this.nameErrorLabel.Visible = false;
            // 
            // surnameErrorLabel
            // 
            this.surnameErrorLabel.AutoSize = true;
            this.surnameErrorLabel.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.surnameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.surnameErrorLabel.Location = new System.Drawing.Point(431, 144);
            this.surnameErrorLabel.Name = "surnameErrorLabel";
            this.surnameErrorLabel.Size = new System.Drawing.Size(132, 16);
            this.surnameErrorLabel.TabIndex = 12;
            this.surnameErrorLabel.Text = "<error-placeholder>";
            this.surnameErrorLabel.Visible = false;
            // 
            // dateOfBirthErrorLabel
            // 
            this.dateOfBirthErrorLabel.AutoSize = true;
            this.dateOfBirthErrorLabel.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateOfBirthErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.dateOfBirthErrorLabel.Location = new System.Drawing.Point(196, 200);
            this.dateOfBirthErrorLabel.Name = "dateOfBirthErrorLabel";
            this.dateOfBirthErrorLabel.Size = new System.Drawing.Size(132, 16);
            this.dateOfBirthErrorLabel.TabIndex = 13;
            this.dateOfBirthErrorLabel.Text = "<error-placeholder>";
            this.dateOfBirthErrorLabel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Salmon;
            this.label5.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(133, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(426, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Since this data is stored in a cloud database, please only use ficticious data";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(669, 370);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateOfBirthErrorLabel);
            this.Controls.Add(this.surnameErrorLabel);
            this.Controls.Add(this.nameErrorLabel);
            this.Controls.Add(this.idNumberErrorLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.postButton);
            this.Controls.Add(this.dateOfBirthDateTimePicker);
            this.Controls.Add(this.idNumberTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idNumberTextBox;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private System.Windows.Forms.Button postButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label idNumberErrorLabel;
        private System.Windows.Forms.Label nameErrorLabel;
        private System.Windows.Forms.Label surnameErrorLabel;
        private System.Windows.Forms.Label dateOfBirthErrorLabel;
        private System.Windows.Forms.Label label5;
    }
}