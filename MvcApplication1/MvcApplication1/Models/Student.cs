using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int StandardId { get; set; }
        public string Contact { get; set; }
        public string Gender { get; set; }
    }
}