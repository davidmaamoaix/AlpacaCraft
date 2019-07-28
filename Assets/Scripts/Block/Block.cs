using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block: Registry {

	public static Block AIR = new Block();

	private Property property;

	public BlockState getDefaultState() {
		return new BlockState(this, true);
	}

	public class Property {

		private float hardness;
	}
}
