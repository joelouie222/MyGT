using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGT.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
    }
}
