using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationExample.Models
{
    public class Incoming
    {
        public string Workflow { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }
        public string BirthDate { get; set; }
    }
}
