using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block: Registry<Block> {

	public static Block AIR = new Block(new Property().hardness(0));
	public static Block DIRT = new Block(new Property().hardness(1));

	private Property property;

	public Block(Property property) {
		this.property = property;
	}

	public BlockState getDefaultState() {
		return new SimpleBlockState(this);
	}

	public class Property {

		private float hard;

		public Property hardness(float hard) {
			this.hard = hard;
			return this;
		}

		public float getHardness() {
			return this.hard;
		}
	}
}
