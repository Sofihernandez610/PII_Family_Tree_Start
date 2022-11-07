using System;

namespace Library
{
    public class Person
    {
        private string name;
        private int edad;

        public Person(String name,int edad)
        {
            this.Name = name;
            this.Edad = edad;
        }

        public string Name{get;}
        public int Edad{get;}

        public void Accept(IVisitor<Person> visitor)
        {
             visitor.Visit(this);
        }
    }
}