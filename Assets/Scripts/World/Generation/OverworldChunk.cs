using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverworldChunk: Chunk {

	public override void generate(int seed, int x, int z) {
		x <<= 4;
		z <<= 4;
		for (int i = 0; i < 16; i++) {
			for (int j = 0; j < 16; j++) {
				for (int k = 0; k < 3; k++) {
					int rand = Random.Range(0, 3);
					Vector3Int pos = new Vector3Int(x | i, k - rand, z | j);
					this.blocks[getIndex(i, k, j)] = Blocks.Instantiate(Blocks.INSTANCE.DIRT, pos, Quaternion.identity);
				}
			} 
		}
	}
}
