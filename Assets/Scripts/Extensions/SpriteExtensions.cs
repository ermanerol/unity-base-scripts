using UnityEngine;

namespace BaseExtensions {

	public static class SpriteExtensions {

		public static Texture2D CutCircleTexture (this Texture2D sourceTex, int size) {
			return sourceTex.CalculateTexture (size, size, (float) size / 2, (float) size / 2, (float) size / 2);
		}

		public static Sprite CutAndSpriteCircleTexture (this Texture2D sourceTex, int size) {
			var tex = sourceTex.CutCircleTexture (size);
			return tex.CreateSprite (size);
		}


		// In case of something doesn't work
		// Algorithm copied from http://answers.unity3d.com/questions/650732/cut-texture2d-in-circle-format.html
		private static Texture2D CalculateTexture (this Texture2D sourceTex, int h, int w, float r, float cx, float cy) {
			var c = sourceTex.GetPixels (0, 0, sourceTex.width, sourceTex.height);
			var b = new Texture2D (h, w);
			try {
				for (int i = 0; i < (h * w); i++) {
					int y = Mathf.FloorToInt ((float)i / (float)w);
					int x = Mathf.FloorToInt ((float)i - (float)(y * w));
					if (r * r >= (x - cx) * (x - cx) + (y - cy) * (y - cy)) {
						b.SetPixel (x, y, c[i]);
					}
					else {
						b.SetPixel (x, y, Color.clear);
					}
				}
				b.Apply ();
			} catch (System.Exception ex) {
				Debug.LogError ("Image couldn't be cut to circle image: " + h + "x" + w + " exception :" + ex);
			}
			return b;
		}

		public static Sprite CreateSprite (this Texture2D sourceTex, int size) {
			return Sprite.Create (
				sourceTex,
				new Rect (0, 0, size, size),
				new Vector2 (0.5f, 0.5f)
			);
		}

	}

}