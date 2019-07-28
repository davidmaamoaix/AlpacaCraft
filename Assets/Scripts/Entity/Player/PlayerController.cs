using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController: MonoBehaviour {

	private const float GRAVITY = 0.01F;
	private const float MAX_FALL = -0.75F;
	private const float SPEED = 5F;
	private const float JUMP_FORCE = 0.3F;
	private const float VROT_RANGE = 90;

	private const float MOUSE_SEN = 5;

	public CharacterController controller;

	private float verticalSpeed;
	private float jumpForce;
	private float vRot;

	void Start () {
		
	}

	void Update () {
		if (this.controller.isGrounded) {
			if (Input.GetKey("space")) {
				this.jumpForce = JUMP_FORCE;
			}
			this.verticalSpeed = Mathf.Max(0, this.verticalSpeed);
		} else {
			if (this.jumpForce == 0) {
				this.verticalSpeed = Mathf.Max(MAX_FALL, this.verticalSpeed - GRAVITY);
			}
		}

		float horizontal = Input.GetAxis("Horizontal") * SPEED * Time.deltaTime;
		float vertical = Input.GetAxis("Vertical") * SPEED * Time.deltaTime;

		float mouseHorizontal = Input.GetAxis("Mouse X") * MOUSE_SEN;
		this.transform.Rotate(0, mouseHorizontal, 0);

		this.vRot -= Input.GetAxis("Mouse Y") * MOUSE_SEN;
		this.vRot = Mathf.Clamp(this.vRot, -VROT_RANGE, VROT_RANGE);
		Camera.main.transform.localRotation = Quaternion.Euler(this.vRot, 0, 0);


		Vector3 move = new Vector3(horizontal, 0, vertical); 
		move = this.transform.rotation * move;
		
		this.verticalSpeed += this.jumpForce / 2.5F;
		move.y = this.verticalSpeed * Time.deltaTime * 45;
		if ((this.jumpForce *= 0.5F) < 0.15) {
			this.jumpForce = 0;
		}

		this.controller.Move(move);

		this.manageMouseInput();
	}

	private void manageMouseInput() {
		Camera camera = Camera.main;
		RaycastHit ray;
		Vector3 pos = camera.ViewportToWorldPoint(Vector3.zero);
		if (Physics.Raycast(pos, camera.transform.forward, out ray)) {
			Block block = ray.collider.gameObject.GetComponent<Block>();
			if (block != null) {
				block.setHover();
			}
		}
	}
}
