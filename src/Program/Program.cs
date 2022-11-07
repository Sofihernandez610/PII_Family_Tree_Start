using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Perdo",80);
            Node<Person> n1 = new Node<Person>(p1);
            Person p2 = new Person("Maria",70);
            Node<Person> n2 = new Node<Person>(p2);
            Person p3 = new Person("Juana",60);
            Node<Person> n3 = new Node<Person>(p3);
            Person p4 = new Person("Juan",50);
            Node<Person> n4 = new Node<Person>(p4);
            Person p5 = new Person("Manuel",40);
            Node<Person> n5 = new Node<Person>(p5);
            Person p6 = new Person("Martin",30);
            Node<Person> n6 = new Node<Person>(p6);
            Person p7 = new Person("Gonzalo",20);
            Node<Person> n7 = new Node<Person>(p7);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            // visitar el árbol aquí
            // Create visitor objects
            VisitorEdad v1 = new VisitorEdad();
            VisitorLongestName v2 = new VisitorLongestName();
            VisitorOldestKid v3 = new VisitorOldestKid();
            // Structure accepting visitors

            n1.Accept(v1);
            Console.WriteLine($"La suma de las edades es:{v1.SumaEdades}");
            n1.Accept(v2);
            Console.WriteLine($"La person con el nombre mas largo es {v2.LongestName}");
            n1.Accept(v3);
            Console.WriteLine($"El mayor de todos es {v3.OldestKid}");

            
        }
    }
            
        
}
