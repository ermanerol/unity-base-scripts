using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BaseExtensions {
	
	public static class NumberExtensions {

		public static float Jiggled (this float f) {
			return Random.Range (f * 0.9f, f * 1.1f);
		}

		public static byte Byte (this Random random) {
			return (byte) Random.Range (0, 255);
		}

		public static float RandomizeSign (this float value) {
			return Random.Range (0, 2) == 0 ? value : -value;
		}

		public static int RandomizeSign (this int value) {
			return Random.Range (0, 2) == 0 ? value : -value;
		}

		public static int MakeNegative (this int value) {
			return -value;
		}

		public static int AbsoluteValue (this int value) {
			return Mathf.Abs (value);
		}

	}

}


