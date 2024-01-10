using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gabriel_ADO.Models
{
    public class Person
    {
        [DisplayName("Id Number")]
        public int PersonID { get; set; }      
        [DisplayName ("First Name")]
        public string FirstName { get; set; }       
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Middle Name")]
        public string MiddleName { get; set; }
        public string Title { get; set; }
        //public string AddressLine1 { get; set; }
        //public string AddressLine2 { get; set; }
        //public string City { get; set; }
        //public string State { get; set; }
        //public string PostalCode { get; set; }
        public string Email { get; set; }
        [DisplayName(" Phone Number")]
        public string PhoneNumber { get; set; }
    }
}