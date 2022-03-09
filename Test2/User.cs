using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    // Account for Name having a second name?
    public class User
    {
        //private static int _nextId = 1;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Initials => Name[0].ToString();
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
