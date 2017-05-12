using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BaseExtensions {

	public static class AudioExtensions {

		public static void Play (this AudioClip clip) {
			AudioSource.PlayClipAtPoint (clip, Vector3.zero, 1.0f);
		}

		public static void PlayPitchShifted (this AudioClip clip) {
			var g = new GameObject(clip.name + " Sound Source");
			var source = g.AddComponent<AudioSource>();
			source.clip = clip;
			g.transform.position = Vector3.zero;
			source.pitch = 1f.Jiggled ();
			source.Play();
			Object.Destroy(g, clip.length + 0.1f);
		}

	}

}
