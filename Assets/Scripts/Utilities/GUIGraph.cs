using UnityEngine;

namespace SanAndreasUnity.Utilities {
	public class GUIGraph {
		private struct Limit {
			public float v;
			public Color c;

			public Limit(float _v, Color _c) {
				v = _v;
				c = _c;
			}
		}

		private Texture2D texture;
		private Color background;
		private Color foreground;
		private System.Collections.Generic.List<Limit> limits;
		private float maximum;

		public GUIGraph (int width, int height, Color bg, Color fg, float max = float.NaN) {
			texture = new Texture2D (width, height, TextureFormat.RGBA32, false, true);
			background = bg;
			foreground = fg;
			maximum = max;
		}

		public void addLimit(float minValue, Color color) {
			if (limits == null) {
				limits = new System.Collections.Generic.List<Limit> ();
			}

			limits.Add (new Limit (minValue, color));
			limits.Sort((x, y) => x.v < y.v ? -1 : (x.v == y.v ? 0 : 1));
		}

		public void draw (Vector2 pos, float[] values, int pointer) {
			// Fill texture with background color
			Color[] colors = new Color[texture.width * texture.height];
			for (int i = 0; i < (texture.width * texture.height); i++) {
				colors [i] = background;
			}
			texture.SetPixels (colors);

			// Draw graph into texture
			for (int i = texture.width - 1; i >= 0; i--) {
				float graphVal = (values [pointer] > maximum) ? maximum : values [pointer];
				int height = (int)(graphVal * texture.height / (maximum + 0.1f));
				Color c = foreground;
				if (limits != null) {
					foreach (Limit l in limits) {
						if (values [pointer] > l.v) {
							c = l.c;
						}
					}
				}
				texture.SetPixel(i, height, c);
				pointer--;
				if (pointer < 0) {
					pointer = values.Length - 1;
				}
			}

			// Draw texture on GUI
			texture.Apply (false, false);
			GUI.DrawTexture (new Rect(pos, new Vector2(texture.width, texture.height)), texture);
		}
	}
}
