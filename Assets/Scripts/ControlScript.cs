using UnityEngine;
using System.Collections;

public class ControlScript : MonoBehaviour {

    public bool useMouse; //or keyboard
	public Vector2 speed;
	private PlayerScript player;
	private Vector2 movement;
	// Update is called once per frame
	void Start(){
		player = GetComponent<PlayerScript>();
	}
    void Update() {
        float inputX = 0, inputY = 0; //Holder variables for input methods
        if (player.isPlayerOne) {
            useMouse = Global.player1_mouse;
        }
        else {
            useMouse = Global.player2_mouse;
        }
        //Different movement method for player 1 and player 2
        /*Axis sensitivity and gravity can be controlled in the Input settings*/
        if (useMouse) {
            inputY = Camera.main.ScreenToWorldPoint(new Vector3(0, Input.mousePosition.y, 0)).y - transform.position.y;
        }
        else { //Use keyboard
            if (player.isPlayerOne) {
                inputX = Input.GetAxis("Horizontal");//Horizontal is included just in case I ever wanted any X-axis shenanigans
                inputY = Input.GetAxis("Vertical");
            }
            else {
                inputX = Input.GetAxis("Horizontal2");
                inputY = Input.GetAxis("Vertical2");
            }
            
        }
        movement = new Vector2(speed.x * inputX, speed.y * inputY);
    }


	void FixedUpdate(){
		rigidbody2D.velocity = movement;
	}
}
