using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HotelReservation2.Models
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Required")]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public int Gender { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Required")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Please Enter Valied Email Id")]
        public string Email { get; set; }
        [Required(AllowEmptyStrings =false,ErrorMessage ="Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }

    
}