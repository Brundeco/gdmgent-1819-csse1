using System;

namespace entities
{
    public class Student : Person
    {
        public string Emailadres
        {
            get;
            set;

        }

        public Education Education
        {
            get;
            set;

        }

        public override string CreatePassword()
        {
            return "Password student";
        }
    }
}