using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business_Logic_Layer.Models
{
    public class PersonModel
    {
      
        public int Id { get; set; }

        [RegularExpression(@"\A[^\d_]+\z", ErrorMessage = "Invalid Data Type")]
        public string FirstName { get; set; }
     
        public string LastName { get; set; }
    
        public string Address { get; set; }
   
        public string PhoneNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}

