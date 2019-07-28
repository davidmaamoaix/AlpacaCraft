using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverworldChunk: Chunk {

	public static SimpleBlockState simpleState;

	public override void generate(int seed, int x, int z) {
		x <<= 4;
		z <<= 4;
		for (int i = 0; i < 16; i++) {
			for (int j = 0; j < 16; j++) {
				for (int k = 0; k < 20; k++) {
					Vector3Int pos = new Vector3Int(x | i, k, z | j);
					this.blockStates[getIndex(i, k, j)] = new SimpleBlockState(Block.DIRT, pos);
				}
			} 
		}
	}
}
