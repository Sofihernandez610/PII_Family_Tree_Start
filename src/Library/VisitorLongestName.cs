using System;

namespace Library
{
    
    public class VisitorLongestName : IVisitor<Node<Person>>, IVisitor<Person>
    {
        private string longestName = "";
        public string LongestName
        {
            get
            {
                return this.longestName;
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

        public  void Visit(Person person)
        {
            if(this.LongestName.Length < person.Name.Length)
            {
                this.longestName = person.Name;
            }
        }
    }


}