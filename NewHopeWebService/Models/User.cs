using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewHopeWebService.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Nullable<int> StateId { get; set; }
        public Nullable<int> CountryId { get; set; }
        public string Address { get; set; }
    }
}