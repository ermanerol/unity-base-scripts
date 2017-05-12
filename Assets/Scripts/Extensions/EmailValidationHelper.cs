using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BaseExtensions {
	
	public static class EmailValidationHelper {

		public static bool IsValid (string mail) {
			var invalid = false;

			if (string.IsNullOrEmpty(mail))
				return false;
			mail = Regex.Replace(mail, @"(@)(.+)$", DomainMapper, RegexOptions.None);

			return Regex.IsMatch(mail,
				@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
				@"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
				RegexOptions.IgnoreCase);
		}

		private static string DomainMapper (Match match){
			var idn = new IdnMapping();
			var domainName = match.Groups[2].Value;
			try {
				domainName = idn.GetAscii(domainName);
			}
			catch (ArgumentException) {
				return "";
			}
			return match.Groups[1].Value + domainName;
		}

	}

}