using UnityEngine;
using System.Collections;
using System;

public class BallScript : MonoBehaviour {

	public float IniSpeed = 5f;
	public float maxSpeed = 20f; 
	public float percentSpeedIncrease = 0.001f;
	public bool randomStart = false;
	public Vector2 direction = new Vector2(-1 , 0);
    public float forceScale = 10; //How much force applied multiplied to collision distance from center
    public float curveScale = 10; //How much curve is applied to ball
    public float constSpeedX;

    public float currentCurve = 0; //How much force applied each fixed update

    public float angVel = 500;
    private float mag;
    private float velY;
    private float velX;
    private float CollisionDistFromCenter;
    

	void Start () {
        constSpeedX = IniSpeed;
		//Set initial random direction
		if(randomStart){
			switch(UnityEngine.Random.Range (0, 4)){
			case 0:
				direction = new Vector2(-1, 1);
				break;
			case 1:
				direction = new Vector2(1, 1);
				break;
			case 2:
				direction = new Vector2(1, -1);
				break;
			case 3:
				direction = new Vector2(-1, -1);
				break;
			}
		}
		rigidbody2D.velocity = new Vector2(IniSpeed * direction.x, IniSpeed * direction.y);

	}


	void FixedUpdate () {
		//Adjust to speed

		//Gradually increasing the speed
	    rigidbody2D.velocity = new Vector2(Math.Sign(rigidbody2D.velocity.x) * constSpeedX, rigidbody2D.velocity.y);
        rigidbody2D.drag = isTooFast() != 0? 0f : 0; //If ball is going too fast, add some drag to it

        Debug.Log("Angular Vel = " + rigidbody2D.angularVelocity);
        rigidbody2D.AddForce(new Vector2(0, rigidbody2D.angularVelocity/250)); //Gives the ball the "curviness" feel. Otherwise it's just a spinny ball
	}


    float isTooFast(){
		//Checks if the ball is moving too fast compared to maxspeed, returns how much over speed limit if it is, else returns 0
        float mag = rigidbody2D.velocity.magnitude;
        if (mag > maxSpeed){
            return mag - maxSpeed;
        }
        else {
            return 0;
        }
	}


    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Player") {
            //Shortened variables
            GameObject player = collision.gameObject;
            Vector2 contactPoint = collision.contacts[0].point;

            //When the ball hit the paddle, the further away it is from the paddle's center, the more force is applied to it, in respective direction
            //CollisionDistFromCenter = contactPoint.y - player.transform.position.y;
            //rigidbody2D.AddForce(new Vector2(0, CollisionDistFromCenter * forceScale));

            //Increasing ball's curve by how fast it was hit by the paddle
            //rigidbody2D.AddTorque(player.rigidbody2D.velocity.y);
        }
    }
}
