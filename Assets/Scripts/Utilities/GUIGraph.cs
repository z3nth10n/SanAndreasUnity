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
		private float minimum;
		private float[] history;
		private int index;

		public GUIGraph (int width, int height, Color bg, Color fg, float max = 100.0f, float min = 0.0f) {
			texture = new Texture2D (width, height, TextureFormat.RGBA32, false, true);
			background = bg;
			foreground = fg;
			maximum = max;
			minimum = min;
			history = new float[width];
			index = 0;
		}

		public void addLimit(float minValue, Color color) {
			if (limits == null) {
				limits = new System.Collections.Generic.List<Limit> ();
			}

			limits.Add (new Limit (minValue, color));
			limits.Sort((x, y) => x.v < y.v ? -1 : (x.v == y.v ? 0 : 1));
		}

		public void draw (Vector2 pos, float value) {
			// Append to history storage
			history [index] = value;

			// Fill texture with background color
			Color[] colors = new Color[texture.width * texture.height];
			for (int i = 0; i < (texture.width * texture.height); i++) {
				colors [i] = background;
			}
			texture.SetPixels (colors);

			// Draw graph into texture
			for (int i = texture.width - 1, pointer = index; i >= 0; i--) {
				float graphVal = history [pointer];
				if (graphVal > maximum) {
					graphVal = maximum;
				}
				if (graphVal < minimum) {
					graphVal = minimum;
				}

				int height = (int)((graphVal - minimum) * texture.height / (maximum - minimum + 0.1f));

				Color c = foreground;
				if (limits != null) {
					foreach (Limit l in limits) {
						if (history [pointer] > l.v) {
							c = l.c;
						}
					}
				}

				texture.SetPixel(i, height, c);

				pointer--;
				if (pointer < 0) {
					pointer = history.Length - 1;
				}
			}

			// Draw texture on GUI
			texture.Apply (false, false);
			GUI.DrawTexture (new Rect(pos, new Vector2(texture.width, texture.height)), texture);

			// Next entry in rolling history buffer
			index++;
			if (index >= history.Length) {
				index = 0;
			}
		}
	}
}
