using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldLoader: MonoBehaviour {

	public static World world;

	public Blocks blocks;

	void Start () {
		blocks.init();

		world = new World();
		for (int i = 0; i < 2; i++) {
			for (int j = 0; j < 2; j++) {
				world.generateChunk(i, j);
			}
		}
	}

	void Update () {
		
	}
}
