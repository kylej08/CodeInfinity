using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class HomeForm : Form
    {
        private UserRepository _userRepository;

        public HomeForm()
        {
            InitializeComponent();

            _userRepository = new UserRepository();
        }

        private void ModifyIdNumberErrorLabelState(string message = "")
        {
            var id = idNumberTextBox.Text;

            if (IDHelper.IsValidId(id))
            {
                idNumberErrorLabel.Visible = false;
            }
            else
            {
                idNumberErrorLabel.Visible = true;
                idNumberErrorLabel.Text = message;
            }
        }

        private void ModifyDateOfBirthErrorLabelState()
        {
            var id = idNumberTextBox.Text;
            var dateOfBirth = dateOfBirthDateTimePicker.Value.Date;

            if (IDHelper.IsValidId(id))
            {
                if (IDHelper.IsDOBComparisonEqual(id, dateOfBirth))
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
                dateOfBirthErrorLabel.Visible = false;
            }
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

        private void idNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            ModifyDateOfBirthErrorLabelState();
            ModifyIdNumberErrorLabelState("The ID number is invalid.");
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
            //var date = dateOfBirthDateTimePicker.Value.Date;
            var id = idNumberTextBox.Text;

            if (IDHelper.IsValidId(id))
            {
                ModifyDateOfBirthErrorLabelState();
            }
        }

        private void postButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(idNumberTextBox.Text))
            {
                ModifyIdNumberErrorLabelState("ID number is required");
                return;
            }
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                nameErrorLabel.Text = "Name is required";
                nameErrorLabel.Visible = true;
                return;
            }
            if (string.IsNullOrWhiteSpace(surnameTextBox.Text))
            {
                surnameErrorLabel.Text = "Surname is required";
                surnameErrorLabel.Visible = true;
                return;
            }

            if (idNumberErrorLabel.Visible || nameErrorLabel.Visible || surnameErrorLabel.Visible || dateOfBirthErrorLabel.Visible)
            {
                return;
            }

            var user = new User()
            {
                IDNumber = idNumberTextBox.Text,
                Name = nameTextBox.Text,
                Surname = surnameTextBox.Text,
                DateOfBirth = dateOfBirthDateTimePicker.Value.ToString("dd/MM/yyyy")
            };

            if (_userRepository.IdNumberExists(user.IDNumber))
            {
                idNumberErrorLabel.Text = "The ID Number already exists.";
                idNumberErrorLabel.Visible = true;

                return;
            }

            idNumberErrorLabel.Visible = false;
            _userRepository.Save(user);

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            idNumberTextBox.Text = String.Empty;
            nameTextBox.Text = String.Empty;
            surnameTextBox.Text = String.Empty;
            dateOfBirthDateTimePicker.Value = dateOfBirthDateTimePicker.MinDate;

            idNumberErrorLabel.Visible = false;
            nameErrorLabel.Visible = false;
            surnameErrorLabel.Visible = false;
            dateOfBirthErrorLabel.Visible = false;

        }

        #endregion

    }
}
