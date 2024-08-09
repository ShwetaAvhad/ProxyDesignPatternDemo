using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPatternDemo.Model
{
    internal class ProxyDatabase : IDatabase
    {
        public IDatabase Database { get; set; }
        public Person Person { get; set; }

        public ProxyDatabase(Person person)
        {
            Person = person;
        }
        public void UpdateDatabase()
        {
            if (Person.PersonRole == "Admin")
            {
                Database = new Database();
                Database.UpdateDatabase();
            }
            else
            {
                Console.WriteLine("You don't have access to database");
            }
        }
    }
}
