using UnityEngine;
using System.Collections;

public class ControlScript : MonoBehaviour {

	public Vector2 speed;
	private PlayerScript player;
	private Vector2 movement;
	// Update is called once per frame
	void Start(){
		player = GetComponent<PlayerScript>();
	}
	void Update () {
		float inputX = 0, inputY = 0; //Holder variables for input methods

        //Different movement method for player 1 and player 2
        /*Axis sensitivity and gravity can be controlled in the Input settings*/
		if(player.isPlayerOne){
			inputX = Input.GetAxis("Horizontal"); //Horizontal is included just in case I ever wanted any X-axis shenanigans
			inputY = Input.GetAxis("Vertical");
        }
        else{
			inputX = Input.GetAxis("Horizontal2");
			inputY = Input.GetAxis("Vertical2");
		}

		movement = new Vector2(speed.x * inputX, speed.y * inputY); 
	}

	void FixedUpdate(){
		rigidbody2D.velocity = movement;
	}
}
