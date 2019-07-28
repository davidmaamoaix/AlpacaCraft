using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BlockState: MonoBehaviour {

	protected Vector3Int pos;
	private bool isVirtual {get;}
	private Block block {get;}

	public BlockState(Block block) {
		this.block = block;
		this.isVirtual = true;
	}

	public BlockState(Block block, Vector3Int pos) {
		this.block = block;
		this.pos = pos;
		this.isVirtual = false;
	}
}
