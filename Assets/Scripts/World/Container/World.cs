using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World: IStateProvider {

	private ChunkMap<int, int, Chunk> chunkMap;

	public BlockState getBlockState(Vector3Int pos) {
		Chunk chunk = this.chunkMap.get(pos.x >> 4, pos.z >> 4);
		if (chunk == null) {
			return null;
		}

		return chunk.getBlockState(pos);
	}
}
