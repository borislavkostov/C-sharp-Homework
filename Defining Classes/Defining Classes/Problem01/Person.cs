using System;
using System.Text.RegularExpressions;

namespace Problem01
{
    class Person
    {
        private string name;
        private byte age;
        private string email;
        
        public Person(string name,byte age,string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }
        public Person(string name, byte age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))//If it's empty console will throw exception
                    throw new ArgumentException("Invalid name!");
                this.name = value;
                {
                }
            }
        }
        public byte Age
        {
            get { return this.age; }
            set
            {
                if (value > 0 && value < 101)//If age is not in range console will throw out of range exception
                {
                    this.age = value;
                }
                else
                {
                throw new IndexOutOfRangeException("Invalid age!");
                }
                
            }
        }
        public string Email { get
        {return this.email;}
            set{ Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");//Regular expresion for matching  email
        Match match = regex.Match(value);
        if (match.Success)
            this.email=value;
        else
            throw new ArgumentException("Invalid email!");
    }
        }
        public override string ToString()
        {
            string s = age.ToString();
            return "Person: " + name + " " + s +" "+ email ?? null ;
        }
        
        }
    }



