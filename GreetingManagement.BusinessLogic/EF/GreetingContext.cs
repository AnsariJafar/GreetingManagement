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

        public System.Data.Entity.DbSet<GreetingManagement.Models.Greeting> Greetings { get; set; }
    }
}
