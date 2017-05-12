using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GOExtensions {

	public static float DistanceTo (this GameObject origin, GameObject target) {
		return Vector3.Distance (origin.transform.position, target.transform.position);
	}

	public static float DistanceTo (this GameObject origin, Vector3 target) {
		return Vector3.Distance (origin.transform.position, target);
	}

	public static float DistanceTo (this Transform origin, Transform target) {
		return Vector3.Distance (origin.position, target.position);
	}

}
