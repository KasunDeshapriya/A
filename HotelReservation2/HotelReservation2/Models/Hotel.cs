using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HotelReservation2.Models
{
    public class Hotel
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HotelId { get; set; }
        
        
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter Hotel Name")]
        public string HotelName { get; set; }
        public string HotelAddress { get; set; }
        [Required(AllowEmptyStrings =false,ErrorMessage ="Please Enter Telephone Number")]
        public string HotelTP { get; set; }
        [DataType(DataType.EmailAddress,ErrorMessage ="Please Enter Valied Email Id")]
        public string HotelEmail { get; set; }
        [Required(AllowEmptyStrings =false,ErrorMessage ="Please Enter How many rooms available")]
        public int TotalRooms { get; set; }


    }
}