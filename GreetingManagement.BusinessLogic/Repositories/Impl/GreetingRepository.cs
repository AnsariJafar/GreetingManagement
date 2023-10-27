using GreetingManagement.BusinessLogic.Common;
using GreetingManagement.BusinessLogic.Repositories.Interface;
using GreetingManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingManagement.BusinessLogic.Repositories.Impl
{
    public class GreetingRepository : GenericRepository<Greeting>,IGreetingRepository
    {
    }
}
