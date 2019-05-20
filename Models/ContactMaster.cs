using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCodeCamp.Models
{
    public class ContactMaster
    {
        public Int32 Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string JobTitle { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }
        public string PhoneNo { get; set; }
    }
}
