using GreetingManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingManagement.BusinessLogic.EF
{
    public class GreetingContext:DbContext
    {
        public GreetingContext():base("ConnSt")
        {

        }

        public DbSet<Greeting> Greetings { get; set; }
        public DbSet<Person> Person { get; set; }
    }
}
