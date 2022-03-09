﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2
{
    public partial class HomeForm : Form
    {
        //private string _csvFilePath;

        private CSVHelper _csvHelper;
        private DataService _dataService;

        
        public HomeForm()
        {
            InitializeComponent();

            //_csvHelper = new CSVHelper(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            //_csvFilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\output.csv";
            _csvHelper = new CSVHelper();
            _dataService = new DataService();

        }

        private void generateCSVFileButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyDocuments;
            if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            _csvHelper.FilePath = $"{folderBrowserDialog.SelectedPath}\\output.csv";
            if (File.Exists(_csvHelper.FilePath))
            {
                var userResponse = MessageBox.Show($"The file {_csvHelper.FilePath} already exists. Do you want to replace it?", "Replace File?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (userResponse != DialogResult.Yes)
                {
                    return;
                }
            }

            try
            {
                var variations = int.Parse(numberOfRecordsTextBox.Text);
                _csvHelper.CreateCSVAsync(variations);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show($"CSV File successfully created ({_csvHelper.FilePath})", "CSV Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            generateCSVFileButton.Enabled = false;
            numberOfRecordsTextBox.Clear();
        }

        private void numberOfRecordsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // the only valid characters are digits and backspace
            if (! char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void numberOfRecordsTextBox_TextChanged(object sender, EventArgs e)
        {
            generateCSVFileButton.Enabled = numberOfRecordsTextBox.Text.Length > 0;
        }

        private void importCSVFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv";

            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            if (! openFileDialog.SafeFileName.Contains("output.csv"))
            {
                MessageBox.Show("A file called output.csv will need to be selected.", "Incorrect File Chosen",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                var userList = _csvHelper.CreateUserListFromCSV(openFileDialog.FileName);
                _dataService.SaveUsers(userList);
                MessageBox.Show($"The file {openFileDialog.FileName} has been successfully imported into the database.", "Import Successful",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
