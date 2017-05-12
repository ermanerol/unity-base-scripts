using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace BaseExtensions {

	public static class EnumExtensions {

		public static T ToEnum<T> (this string s, bool ignoreCase = false) where T : struct {
			if (s.IsNullOrEmpty())
				return default(T);

			var genericType = typeof(T);
			if (!genericType.IsEnum)
				return default(T);

			try {
				return (T) Enum.Parse(genericType, s, ignoreCase);
			}

			catch (Exception) {
				var ary = Enum.GetValues(genericType);
				foreach (var en in ary.Cast<T>()
					.Where(en =>
						(string.Compare(en.ToString(), s, ignoreCase) == 0) ||
						(string.Compare((en as Enum).ToString(), s, ignoreCase) == 0)))
				{
					return en;
				}

				return default(T);
			}
		}

	}

}
