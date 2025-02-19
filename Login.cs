﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Asp_Identity.ViewModels
{
	public class Login
	{

		[Required]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }
		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }


		
	}
}

