using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BaseExtensions {

	public static class ListExtensions {

		public static bool IsNullOrEmpty<T> (this T[] data) {
			return (data == null) || (data.Length == 0);
		}

		public static bool IsNullOrEmpty<T> (this List<T> list) {
			return (list == null) || (list.Count == 0);
		}

		public static bool IsNullOrEmpty<T1, T2> (this Dictionary<T1,T2> data) {
			return (data == null) || (data.Count == 0);
		}

		public static T RandomElement<T> (this IList<T> list) {
			return list[Random.Range (0, list.Count)];
		}

		public static void Shuffle<T> (this IList<T> list) {
			//Fisher-Yates method, copied from stackoverflow
			var rng = new System.Random ();
			var n = list.Count;
			while (n > 1) {
				n--;
				var k = rng.Next (n + 1);
				T value = list[k];
				list[k] = list[n];
				list[n] = value;
			}
		}

		public static T TakeOutRandom<T> (this IList<T> list) {
			var index = Random.Range (0, list.Count);
			T item = list[index];
			list.RemoveAt (index);
			return item;
		}

	}

}
