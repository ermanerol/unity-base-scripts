using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;

namespace BaseExtensions {

	public static class StringExtensions {

		public static string CutToLength (this string value, int length) {
			if (string.IsNullOrEmpty(value))
				return value;
			return value.Length <= length ? value : value.Substring(0, length);
		}

		public static string Reverse (this string value) {
			var chars = value.ToCharArray();
			Array.Reverse(chars);
			return new string(chars);
		}

		public static int GetWordCount (this string s) {
			return new Regex(@"\w+").Matches(s).Count;
		}

		public static bool IsNullOrEmpty (this string value) {
			return string.IsNullOrEmpty(value);
		}

		public static string RemoveSpaces (this string value) {
			return value.Replace(" ", string.Empty);
		}

		public static List<char> ToCharList (this string s) {
			return s.IsNullOrEmpty() ? null : s.ToCharArray().ToList();
		}

		public static bool IsDate (this string value) {
			try {
				DateTime tempDate;
				return DateTime.TryParse(value, out tempDate);
			}
			catch (Exception){
				return false;
			}
		}

	}

}