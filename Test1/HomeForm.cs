using MongoDB.Bson;
using MongoDB.Driver;
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
    public class UserRepository
    {
        private IMongoDatabase _db;

        private readonly string _connectionString = "mongodb://localhost:27017";
        private readonly string _dbName = "CodeInfinity";

        public UserRepository()
        {
            var client = new MongoClient(_connectionString);
            _db = client.GetDatabase(_dbName);
        }


        //collection _db.GetCollection<User>("")
        // 
        
        public void Save(User user)
        {
            var collection = _db.GetCollection<User>("Users");
            var document = collection.Find(new BsonDocument()).FirstOrDefault();

            if (document == null)
            {
                collection.InsertOne(user);
            }
            else
            {
                var filter = Builders<User>.Filter.Eq(nameof(user.Id), user.Id);
                collection.ReplaceOne(filter, user, new ReplaceOptions { IsUpsert = true});
            }
        }

        public void Get()
        {

        }
    }

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

            var user = new User()
            {
                IDNumber = idNumberTextBox.Text,
                Name = nameTextBox.Text,
                Surname = surnameTextBox.Text,
                DateOfBirth = dateOfBirthDateTimePicker.Value.ToShortDateString()
            };

            _userRepository.Save(user);
        }

        #endregion

    }
}
