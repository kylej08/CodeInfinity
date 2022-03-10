namespace Test2
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
            this.generateCSVFileButton = new System.Windows.Forms.Button();
            this.importCSVFileButton = new System.Windows.Forms.Button();
            this.numberOfRecordsTextBox = new System.Windows.Forms.TextBox();
            this.numberOfRecordsLabel = new System.Windows.Forms.Label();
            this.generateCSVProgressLabel = new System.Windows.Forms.Label();
            this.importCSVProgressLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // generateCSVFileButton
            // 
            this.generateCSVFileButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.generateCSVFileButton.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.generateCSVFileButton.Location = new System.Drawing.Point(147, 106);
            this.generateCSVFileButton.Name = "generateCSVFileButton";
            this.generateCSVFileButton.Size = new System.Drawing.Size(227, 23);
            this.generateCSVFileButton.TabIndex = 0;
            this.generateCSVFileButton.Text = "Generate CSV File";
            this.generateCSVFileButton.UseVisualStyleBackColor = true;
            this.generateCSVFileButton.Click += new System.EventHandler(this.generateCSVFileButton_Click);
            // 
            // importCSVFileButton
            // 
            this.importCSVFileButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.importCSVFileButton.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.importCSVFileButton.Location = new System.Drawing.Point(147, 167);
            this.importCSVFileButton.Name = "importCSVFileButton";
            this.importCSVFileButton.Size = new System.Drawing.Size(235, 23);
            this.importCSVFileButton.TabIndex = 1;
            this.importCSVFileButton.Text = "Import CSV File";
            this.importCSVFileButton.UseVisualStyleBackColor = true;
            this.importCSVFileButton.Click += new System.EventHandler(this.importCSVFileButton_Click);
            // 
            // numberOfRecordsTextBox
            // 
            this.numberOfRecordsTextBox.Location = new System.Drawing.Point(273, 77);
            this.numberOfRecordsTextBox.MaxLength = 7;
            this.numberOfRecordsTextBox.Name = "numberOfRecordsTextBox";
            this.numberOfRecordsTextBox.Size = new System.Drawing.Size(108, 23);
            this.numberOfRecordsTextBox.TabIndex = 2;
            this.numberOfRecordsTextBox.TextChanged += new System.EventHandler(this.numberOfRecordsTextBox_TextChanged);
            this.numberOfRecordsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberOfRecordsTextBox_KeyPress);
            // 
            // numberOfRecordsLabel
            // 
            this.numberOfRecordsLabel.AutoSize = true;
            this.numberOfRecordsLabel.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberOfRecordsLabel.Location = new System.Drawing.Point(139, 80);
            this.numberOfRecordsLabel.Name = "numberOfRecordsLabel";
            this.numberOfRecordsLabel.Size = new System.Drawing.Size(128, 16);
            this.numberOfRecordsLabel.TabIndex = 3;
            this.numberOfRecordsLabel.Text = "Number of Records:";
            // 
            // generateCSVProgressLabel
            // 
            this.generateCSVProgressLabel.AutoSize = true;
            this.generateCSVProgressLabel.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.generateCSVProgressLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.generateCSVProgressLabel.Location = new System.Drawing.Point(147, 132);
            this.generateCSVProgressLabel.Name = "generateCSVProgressLabel";
            this.generateCSVProgressLabel.Size = new System.Drawing.Size(220, 16);
            this.generateCSVProgressLabel.TabIndex = 4;
            this.generateCSVProgressLabel.Text = "<CSV-Generate-Progress-Message>";
            this.generateCSVProgressLabel.Visible = false;
            // 
            // importCSVProgressLabel
            // 
            this.importCSVProgressLabel.AutoSize = true;
            this.importCSVProgressLabel.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.importCSVProgressLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.importCSVProgressLabel.Location = new System.Drawing.Point(147, 193);
            this.importCSVProgressLabel.Name = "importCSVProgressLabel";
            this.importCSVProgressLabel.Size = new System.Drawing.Size(207, 16);
            this.importCSVProgressLabel.TabIndex = 5;
            this.importCSVProgressLabel.Text = "<CSV-Import-Progress-Message>";
            this.importCSVProgressLabel.Visible = false;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(525, 325);
            this.Controls.Add(this.importCSVProgressLabel);
            this.Controls.Add(this.generateCSVProgressLabel);
            this.Controls.Add(this.numberOfRecordsLabel);
            this.Controls.Add(this.numberOfRecordsTextBox);
            this.Controls.Add(this.importCSVFileButton);
            this.Controls.Add(this.generateCSVFileButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateCSVFileButton;
        private System.Windows.Forms.Button importCSVFileButton;
        private System.Windows.Forms.TextBox numberOfRecordsTextBox;
        private System.Windows.Forms.Label numberOfRecordsLabel;
        private System.Windows.Forms.Label generateCSVProgressLabel;
        private System.Windows.Forms.Label importCSVProgressLabel;
    }
}