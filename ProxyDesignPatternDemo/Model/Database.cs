using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPatternDemo.Model
{
    internal class Database : IDatabase
    {
        public void UpdateDatabase()
        {
            Console.WriteLine("Database Updated Successfully!");
        }
    }
}
