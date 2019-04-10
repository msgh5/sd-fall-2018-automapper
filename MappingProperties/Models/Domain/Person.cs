using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MappingProperties.Models.Domain
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public DateTime DateCreated { get; set; }
    }
}