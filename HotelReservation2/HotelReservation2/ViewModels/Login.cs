﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelReservation2.ViewModels
{
    public class Login
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}