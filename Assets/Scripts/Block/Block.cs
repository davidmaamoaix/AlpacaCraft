using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block: MonoBehaviour {

	public float hardness;
	public Material material;

	private Renderer blockRenderer;
	private bool hover;

	public Block(float hardness) {
		this.hardness = hardness;
	}

	void Start() {
		this.blockRenderer = this.GetComponent<Renderer>();
	}

	void Update() {
		this.blockRenderer.material = this.hover ? Blocks.INSTANCE.WHITE : this.material;

		this.hover = false;
	}

	public void setHover() {
		this.hover = true;
	}
}
