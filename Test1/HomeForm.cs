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

            if (id.Length == 13 && (id[10] == '0' || id[10] == '1'))
            {
                idNumberErrorLabel.Visible = false;
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

            //if id number is valid
            if (idNumberTextBox.TextLength == 13)
            {
                var id = idNumberTextBox.Text;
                if (! (date.Year == GetYearForId(id) && date.Month == GetMonthForId(id) && date.Day == GetDayForId(id)))
                {
                    dateOfBirthErrorLabel.Text = "Date of Birth conflicts with the ID";
                    dateOfBirthErrorLabel.Visible = true;

                    idNumberErrorLabel.Text = "ID conflicts with Date of Birth";
                    idNumberErrorLabel.Visible = true;
                }
                else
                {
                    dateOfBirthErrorLabel.Visible = false;
                    idNumberErrorLabel.Visible = false;
                }
            }
        }

        #endregion

        private int GetYearForId(string id)
        {
            return int.Parse("19" + id.Substring(0, 2));
        }

        private int GetMonthForId(string id)
        {
            return int.Parse(id.Substring(2, 2));
        }

        private int GetDayForId(string id)
        {
            return int.Parse(id.Substring(4, 2));
        }
       
    }

    public static class IDValidator
    {
        //public static bool IsValid(string idNumber)
        //{
 
        //}
    }
}
