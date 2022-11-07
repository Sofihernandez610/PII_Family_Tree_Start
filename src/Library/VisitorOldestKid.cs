using System;

namespace Library
{
    public class VisitorOldestKid : IVisitor<Node<Person>>, IVisitor<Person>
    {
        private int oldestKid = 0;
        public int OldestKid
        {
            get
            {
                return this.oldestKid;
            }
        }
        public void Visit(Node<Person> node)
        {
            node.Content.Accept(this);
           foreach(Node<Person> item in node.Children)
           {
               item.Accept(this);
           }
        }

        public void Visit(Person person)
        {
            if(this.OldestKid < person.Edad)
            {
                this.oldestKid = person.Edad;
            }
        }
    }

}