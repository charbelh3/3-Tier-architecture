using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication6.Repository.Entities

{
    public partial class Person
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("first_name")]
        [StringLength(100)]

        public string FirstName { get; set; }
        [Column("last_name")]
        [StringLength(100)]
        public string LastName { get; set; }
        [Column("address")]
        [StringLength(1000)]
        public string Address { get; set; }
        [Column("phone_number")]
        [StringLength(100)]
        public string PhoneNumber { get; set; }
        [Column("date_of_birth", TypeName = "date")]
        public DateTime? DateOfBirth { get; set; }


    }
}
