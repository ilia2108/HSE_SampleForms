using System;
using System.Collections.Generic;
using System.Text;

namespace SampleForms
{
    class Human
    {
        public string Name { get; private set; }
        private string surname;
        private int age;


        public Human(string name = "", string surname = "", int age = 0)
        {
            this.Name = name;
            this.surname = surname;
            this.age = age;
        }
        /*
        string getName()
        {
            return name;
        }
        void setName(string value)
        {
            name = value;
        }
        */
        /*
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        */
    }
}
