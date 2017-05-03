using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BaseExtensions {
	
	public static class ColorExtensions {

		public static Color Random (this Color color) {
			var random = new Random ();
			return new Color (random.Byte (), random.Byte (), random.Byte ());
		}

		public static void Randomize (this Color color) {
			var random = new Random ();
			color = new Color (random.Byte (), random.Byte (), random.Byte ());
		}

		public static void SetAlpha(this Color color, float alpha) {
			Color newColor = color;
			newColor.a = alpha;
			color = newColor;
		}

	}


}
