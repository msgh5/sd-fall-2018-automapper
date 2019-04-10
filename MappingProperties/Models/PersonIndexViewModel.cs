using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MappingProperties.Models
{
    public class PersonIndexViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Created { get; set; }
    }
}