using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPatternDemo.Model
{
    public class Person
    {
        public string PersonName { get; set; }
        public string PersonRole { get; set; }
        public Person(string name, string role)
        {
            PersonName = name;
            PersonRole = role;
        }
        public override string ToString()
        {
            return $"Person Name : {PersonName}\n" +
                   $"Person Role : {PersonRole}";
        }
    }
}
