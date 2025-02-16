using DISandbox.Interfaces;

namespace DISandbox.Classes
{
    public class Person : IPerson
    {
        public string Name { get; set; }
        public double Balance { get; set; }

        public Person(string name, double balance) 
        { 
            Name = name;
            Balance = balance;
        }
    }
}
