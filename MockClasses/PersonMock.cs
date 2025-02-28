using DISandbox.Interfaces;

namespace DISandbox.MockClasses
{
    public class PersonMock : IPerson
    {
        public string Name { get; set; }
        public double Balance { get; set; }

        public PersonMock(string name, double balance) 
        { 
            Name = name;
            Balance = balance;
        }
    }
}
