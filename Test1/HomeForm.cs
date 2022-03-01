using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        #region Events

        private void idNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only accept digits, and backspace
            if (! char.IsDigit(e.KeyChar) && ! e.KeyChar.Equals('\b'))
            {
                e.Handled = true;
            }
        }

        private void idNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            var id = idNumberTextBox.Text;

            if (IDHelper.IsValidId(id))
            {
                idNumberErrorLabel.Visible = false;

                if (IDHelper.IsDOBComparisonEqual(id, dateOfBirthDateTimePicker.Value))
                {
                    dateOfBirthErrorLabel.Visible = false;
                }
                else
                {
                    dateOfBirthErrorLabel.Text = "Date of Birth conflicts with the ID";
                    dateOfBirthErrorLabel.Visible = true;
                }
            }
            else
            {
                idNumberErrorLabel.Visible = true;
                idNumberErrorLabel.Text = "The ID number is invalid.";
            }
        }

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allow only letters, backspace and whitespace
            if (! char.IsLetter(e.KeyChar) && ! e.KeyChar.Equals('\b') && ! char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void surnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allow only letters, backspace and whitespace
            if (!char.IsLetter(e.KeyChar) && !e.KeyChar.Equals('\b') && ! char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void postButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idNumberTextBox.Text))
            {
                idNumberErrorLabel.Text = "ID number is required";
                idNumberErrorLabel.Visible = true;
            }
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                nameErrorLabel.Text = "Name is required";
                nameErrorLabel.Visible = true;
            }
            if (string.IsNullOrWhiteSpace(surnameTextBox.Text))
            {
                surnameErrorLabel.Text = "Surname is required";
                surnameErrorLabel.Visible = true;
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (nameTextBox.TextLength > 0 && ! string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                nameErrorLabel.Visible = false;
            }
        }

        private void surnameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (surnameTextBox.TextLength > 0 && ! string.IsNullOrWhiteSpace(surnameTextBox.Text))
            {
                surnameErrorLabel.Visible = false;
            }
        }

        private void dateOfBirthDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            var date = dateOfBirthDateTimePicker.Value.Date;
            var id = idNumberTextBox.Text;

            if (IDHelper.IsValidId(id))
            {
                if (IDHelper.IsDOBComparisonEqual(id, date))
                {
                    dateOfBirthErrorLabel.Visible = false;
                    //idNumberErrorLabel.Visible = false;
                }
                else
                {
                    dateOfBirthErrorLabel.Text = "Date of Birth conflicts with the ID";
                    dateOfBirthErrorLabel.Visible = true;

                    //idNumberErrorLabel.Text = "ID conflicts with Date of Birth";
                    //idNumberErrorLabel.Visible = true;
                }
            }
        }

        #endregion


       
    }

    public static class IDHelper
    {
        public static bool IsValidId(string id)
        {
            return id.Length == 13 && (id[10] == '0' || id[10] == '1');
        }


        public static bool IsDOBComparisonEqual(string id, DateTime date)
        {
            return date.Year == GetYearForId(id)
                    && date.Month == GetMonthForId(id)
                    && date.Day == GetDayForId(id);
        }

        private static int GetYearForId(string id)
        {
            return int.Parse("19" + id.Substring(0, 2));
        }

        private static int GetMonthForId(string id)
        {
            return int.Parse(id.Substring(2, 2));
        }

        private static int GetDayForId(string id)
        {
            return int.Parse(id.Substring(4, 2));
        }

    }
}
