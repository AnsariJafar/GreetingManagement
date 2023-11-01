using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GreetingManagement.WebUI.Models
{
    public class GreetingViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DOB { get; set; }
        public string DOJ { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
    }
}