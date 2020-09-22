using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0922
{
    interface IMan
    {
        string Name { get; set; }
        void Save();
        void Show();
    }
    interface IPerson : IMan
    {
        int Age { get; set; }
    }
    class Employee : IPerson
    {
        int age;
        //public int Age { get => age; set => value; }
        public int Age { get { return age; } set{ age= value; } }
        string name;
        // public string Name { get => name;  set => value; }
        public string Name { get { return name; } set { name = value; } }

        public void Save()
        {
            Console.WriteLine("Name: " + this.name);
        }

        public void Show()
        {
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Age: " + this.age);
        }
    }
    class Class3
    {
        static void Main()
        {
            Employee man = new Employee();
//            man.
        }
    }
}
