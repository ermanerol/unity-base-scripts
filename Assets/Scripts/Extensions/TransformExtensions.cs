using UnityEngine;

namespace BaseExtensions {

	public static class TransformExtensions {

		public static void SetX (this Transform transform, float x) {
			transform.position = new Vector3 (x, transform.position.y, transform.position.z);
		}

		public static void SetY (this Transform transform, float y) {
			transform.position = new Vector3 (transform.position.x, y, transform.position.z);
		}

		public static void SetZ (this Transform transform, float z) {
			transform.position = new Vector3 (transform.position.x, transform.position.y, z);
		}

		public static void SetLocalX (this Transform transform, float x) {
			transform.localPosition = new Vector3 (x, transform.localPosition.y, transform.localPosition.z);
		}

		public static void SetLocalY (this Transform transform, float y) {
			transform.localPosition = new Vector3 (transform.localPosition.x, y, transform.localPosition.z);
		}

		public static void SetLocalZ (this Transform transform, float z) {
			transform.localPosition = new Vector3 (transform.localPosition.x, transform.localPosition.y, z);
		}

		public static void Reset (this Transform transform) {
			transform.localPosition = Vector3.zero;
			transform.rotation = Quaternion.identity;
			transform.localScale = Vector3.one;
		}

		public static void ResetLocalY(this Transform transform) {
			transform.localPosition = new Vector3(transform.localPosition.x, 0f, transform.localPosition.z);
		}

		public static void Add (this Transform transform, float x, float y, float z) {
			transform.localPosition =  new Vector3(transform.localPosition.x + x, transform.localPosition.y + y, transform.localPosition.z + z);
		}

		public static void AddX (this Transform transform, float add) {
			transform.position = new Vector3(transform.position.x + add, transform.position.y, transform.position.z);
		}

		public static void AddY (this Transform transform, float add) {
			transform.position = new Vector3(transform.position.x, transform.position.y + add, transform.position.z);
		}

		public static void AddZ (this Transform transform, float add) {
			transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + add);
		}

		public static void AddLocalX (this Transform transform, float add) {
			transform.localPosition = new Vector3(transform.localPosition.x + add, transform.localPosition.y, transform.localPosition.z);
		}

		public static void AddLocalY (this Transform transform, float add) {
			transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + add, transform.localPosition.z);
		}

		public static void AddLocalZ (this Transform transform, float add) {
			transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z + add);
		}

	}
}
