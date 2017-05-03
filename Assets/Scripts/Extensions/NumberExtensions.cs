using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BaseExtensions {
	
	public static class NumberExtensions {

		public static byte Byte (this Random random) {
			return (byte) Random.Range (0, 255);
		}

	}

}


