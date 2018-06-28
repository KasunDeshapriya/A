using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HotelReservation2.Models
{
    public class Booking
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookingId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int BookedRooms { get; set; }
        public int HotelId { get; set; }
        public virtual Hotel hotel { get; set; }

    }
}