﻿using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BaseExtensions;
using UnityEngine;

namespace BaseExtensions {

	public static class TransformExtensions {

		public static void SetX (this Transform transform, float x) {
			transform.position = new Vector3 (x, transform.position.y, transform.position.z);
		}

		public static void SetLocalX (this Transform transform, float x) {
			transform.localPosition = new Vector3 (x, transform.localPosition.y, transform.localPosition.z);
		}

		public static void SetY (this Transform transform, float y) {
			transform.position = new Vector3 (transform.position.x, y, transform.position.z);
		}

		public static void SetLocalY (this Transform transform, float y) {
			transform.localPosition = new Vector3 (transform.localPosition.x, y, transform.localPosition.z);
		}

		public static void SetZ (this Transform transform, float z) {
			transform.position = new Vector3 (transform.position.x, transform.position.y, z);
		}

		public static void SetLocalZ (this Transform transform, float z) {
			transform.localPosition = new Vector3 (transform.localPosition.x, transform.localPosition.y, z);
		}

		public static void Reset (this Transform transform) {
			transform.localPosition = Vector3.zero;
			transform.rotation = Quaternion.identity;
			transform.localScale = Vector3.one;
		}

	}
}

public class Test : MonoBehaviour {

	void Awake () {
		transform.SetX (2f);
		transform.Reset ();
	}

}
