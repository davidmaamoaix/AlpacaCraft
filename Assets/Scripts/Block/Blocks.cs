using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks: MonoBehaviour {

	public static Blocks INSTANCE;

	public Block DIRT;

	public Material WHITE;

	public void init() {
		INSTANCE = this;
	}
}
