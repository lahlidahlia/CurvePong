using UnityEngine;
using System.Collections;

public class ControlScript : MonoBehaviour {

	public Vector2 speed = new Vector2(5, 0);
	PlayerScript player;
	Vector2 movement;
	// Update is called once per frame
	void Start(){
		player = GetComponent<PlayerScript>();
	}
	void Update () {
		float inputX = 0, inputY = 0;
		switch(player.isPlayerOne){
		case false:
			inputX = Input.GetAxis("Horizontal2");
			inputY = Input.GetAxis("Vertical2");
			break;
		case true:
			inputX = Input.GetAxis("Horizontal");
			inputY = Input.GetAxis("Vertical");
			break;
		}

		movement = new Vector2(speed.x * inputX, speed.y * inputY);
	}

	void FixedUpdate(){
		rigidbody2D.velocity = movement;
	}
}
