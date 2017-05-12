using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BaseExtensions {
	
	public static class ColorExtensions {

		public static Color Randomize (this Color color) {
			var random = new Random ();
			color = new Color (random.Byte (), random.Byte (), random.Byte ());
			return color;
		}

		public static Color SetAlpha(this Color color, float alpha) {
			return new Color (color.r, color.g, color.b, alpha);
		}

	}


}
