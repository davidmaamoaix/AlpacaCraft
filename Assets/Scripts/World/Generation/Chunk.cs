using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Chunk: IStateProvider {

	private const int LENGTH = 16 * 256 * 16;

	protected BlockState[] blockStates;

	public Chunk() {
		this.blockStates = new BlockState[LENGTH];
	}

	public BlockState getBlockState(Vector3Int pos) {
		return this.blockStates[getIndex(pos.x >> 4, pos.y, pos.z >> 4)] ?? Block.AIR.getDefaultState();
	}

	protected static int getIndex(int x, int y, int z) {
		return x << 12 | z << 8 | y;
	}

	protected static Vector3Int getBlockPos(int index) {
		int y = index & 255;
		index >>= 8;
		int z = index & 15;
		index >>= 4;
		return new Vector3Int(index & 15, y, z);
	}

	public abstract void generate(int seed, int x, int z);
}
