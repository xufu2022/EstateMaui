﻿#nullable enable
using System;
namespace RealEstateApp.Models
{
	public class Login
	{
		public string Email { get; set; } = default!;
        public string Password { get; set; } = default!;

        public string? Name { get; set; } = "";
        //public string Email { get; set; }
        //public string Password { get; set; }
        public string? Phone { get; set; } = "";
    }
}

