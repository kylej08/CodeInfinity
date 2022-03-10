using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    public class RandomUserGenerator
    {
        private int _nextId = 1;

        private string[] _names;
        private string[] _surnames;

        public event EventHandler UserGenerated;

        public RandomUserGenerator()
        {
            _names = PopulateNames();
            _surnames = PopulateSurnames();
        }

        public LinkedList<User> CreateUserList(int amount)
        {
            _nextId = 1;
            //var users = new List<User>();
            var users = new LinkedList<User>();

            for (int i = 0; i < amount; i++)
            {
                while (true)
                {
                    var user = CreateUser();
                    //var userExists = users.Exists(x => x.Name.Equals(user.Name)
                    //    && x.Surname.Equals(x.Surname)
                    //    && x.DateOfBirth.Date == user.DateOfBirth.Date
                    //    && x.Age == user.Age);

                    var userExists = users.SingleOrDefault(x => x.Name.Equals(user.Name)
                        && x.Surname.Equals(x.Surname)
                        && x.DateOfBirth.Date == user.DateOfBirth.Date
                        && x.Age == user.Age) != null;

                    if (!userExists)
                    {
                        users.AddLast(user);
                        break;
                    }
                }
                UserGenerated.Invoke(this, new EventArgs());
            }

            return users;
        }

        private User CreateUser()
        {
            var dateOfBirth = GenerateDateOfBirth();

            return new User
            {
                Id = _nextId++,
                Name = GenerateName(),
                Surname = GenerateSurname(),
                DateOfBirth = dateOfBirth,
                Age = CalculateAge(dateOfBirth)
            };
        }

        private string GenerateName()
        {
            var index = new Random().Next(0, 20);

            return _names[index];
        }

        private string GenerateSurname()
        {
            var index = new Random().Next(0, 20);

            return _surnames[index];
        }

        private DateTime GenerateDateOfBirth()
        {
            var randomNumberGenerator = new Random();

            var randomYear = randomNumberGenerator.Next(1930, 2023);
            var randomMonth = randomNumberGenerator.Next(1, 13);

            var daysInMonth = DateTime.DaysInMonth(randomYear, randomMonth);

            var randomDay = randomNumberGenerator.Next(1, daysInMonth + 1);

            return new DateTime(randomYear, randomMonth, randomDay);
        }

        private int CalculateAge(DateTime dateOfBirth)
        {
            var age = DateTime.Now.Year - dateOfBirth.Year;

            if (dateOfBirth.Month < DateTime.Now.Month
                || (dateOfBirth.Month == DateTime.Now.Month && dateOfBirth.Day < DateTime.Now.Day))
            {
                age -= 1;
            }

            return age;
        }


        private string[] PopulateNames()
        {
            var names = new string[20];

            names[0] = "Mike";
            names[1] = "Matthew";
            names[2] = "Alex";
            names[3] = "Kyle";
            names[4] = "Kylee";
            names[5] = "Jane";
            names[6] = "Jannet";
            names[7] = "Dave";
            names[8] = "Gary";
            names[9] = "Susan";
            names[10] = "Mario";
            names[11] = "Lisa";
            names[12] = "Michelle";
            names[13] = "Kelly";
            names[14] = "John";
            names[15] = "Rachelle";
            names[16] = "Richard";
            names[17] = "Sandy";
            names[18] = "Peter";
            names[19] = "Phillip";

            return names;
        }

        private string[] PopulateSurnames()
        {
            var surnames = new string[20];

            surnames[0] = "Dyer";
            surnames[1] = "Morton";
            surnames[2] = "Shelton";
            surnames[3] = "Gray";
            surnames[4] = "York";
            surnames[5] = "Ferrell";
            surnames[6] = "Stuart";
            surnames[7] = "Navarro";
            surnames[8] = "Flores";
            surnames[9] = "Gates";
            surnames[10] = "Bullock";
            surnames[11] = "Cordova";
            surnames[12] = "Navarro";
            surnames[13] = "Torres";
            surnames[14] = "Bishop";
            surnames[15] = "Ross";
            surnames[16] = "Franco";
            surnames[17] = "Hogan";
            surnames[18] = "Nixon";
            surnames[19] = "Chavez";

            return surnames;
        }
    }
}
