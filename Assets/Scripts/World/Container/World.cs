using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World: IBlockProvider {

	private ChunkMap<int, int, Chunk> chunkMap;

	public World() {
		this.chunkMap = new ChunkMap<int, int, Chunk>();
	}

	public Block getBlock(Vector3Int pos) {
		Chunk chunk = this.chunkMap.get(pos.x >> 4, pos.z >> 4);
		if (chunk == null) {
			return null;
		}

		return chunk.getBlock(pos);
	}

	public void generateChunk(int x, int z) {
		Chunk chunk = new OverworldChunk();
		chunk.generate(125, x, z);
		this.chunkMap.set(x, z, chunk);
	}
}
