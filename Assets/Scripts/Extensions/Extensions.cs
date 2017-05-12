using System.IO;
using System.Text;
using UnityEngine;

namespace BaseExtensions {
	public static class Extensions {
		public static T RandomElement<T> (this T[] array) {
			return array[Random.Range (0, array.Length)];
		}

		public static string ByteArrayToString (this byte[] source) {
			if (source.IsNullOrEmpty ())
				return string.Empty;
			using (var compMemStream = new MemoryStream (source)) {
				using (var reader = new StreamReader (compMemStream, Encoding.UTF8)) {
					return reader.ReadToEnd ();
				}
			}
		}
	}
}