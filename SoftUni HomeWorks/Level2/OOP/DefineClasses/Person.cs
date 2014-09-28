using System;

namespace DefineClasses
{
    class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Person(string name, int age)
            : this(name, age, null)
        {
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if ((value < 1) || (value > 100))
                {
                    throw new ArgumentOutOfRangeException("Invalid age, allowed range is from 1 to 100");
                }

                this.age = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    this.email = null;
                }
                else
                {
                    if (value.IndexOf("@") < 0)
                    {
                        throw new ArgumentException("Email is not valid. Email should content a '@'");
                    }
                    this.email = value;
                }
            }
        }

        public override string ToString()
        {
            return String.Format("Name : %s; Age : %s; Email : %s", this.Name, this.Age, this.Email);
        }
    }
}

