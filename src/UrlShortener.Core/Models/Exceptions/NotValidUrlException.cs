﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrlShortener.Core.Models.Exceptions
{
	public class NotValidUrlException : Exception
	{
		public NotValidUrlException() : base("Введенный url некорректен.")
		{

		}
	}
}
