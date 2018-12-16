using System;

namespace entities
{
    public class Person : User
    {
        public string LastName
        {
            get;
            set;
        }

        public string FullName
        {
            get
            {
                return this.name + " " + this.firstname;
            }
        }

        private string name;
        private string firstname;
        public DateTime birthdate
        {
            get;

            set;

        }
        public string Firstname
        {
            get
            {
                return this.firstname;
            }
            set
            {
                this.firstname = value;
            }

        }
        public int Age()
        {
            return 18;
        }

        public string CreatePassword(string input)
        {
            return input;
        }
        public int CreatePassword(int input)
        {
            return input;
        }
    }
}