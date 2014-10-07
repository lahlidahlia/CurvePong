using UnityEngine;
using System.Collections;

public class GameSetupScript : MonoBehaviour {
	public Camera mainCam;

	public Transform player1;
	public Transform player2;

    //How far away is the object from the edge of the screen
    public int pxFromScreen = 75;

	public GameObject[] balls;
	public Transform wall1;
	public Transform wall2;
	public Transform goal1;
	public Transform goal2;
	public Transform midline;



	void Start () {
		balls = GameObject.FindGameObjectsWithTag("Ball");

        //Setup the position of all the objects
		player1.position = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(pxFromScreen, 0,0)).x, mainCam.ViewportToWorldPoint(new Vector3(0, 0.5f, 0)).y);
		player2.position = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width - pxFromScreen, 0,0)).x, mainCam.ViewportToWorldPoint(new Vector3(0, 0.5f, 0)).y);
		wall1.position = new Vector2(mainCam.ViewportToWorldPoint(new Vector3(0.5f, 0,0)).x, mainCam.ViewportToWorldPoint(new Vector3(0, 1f, 0)).y);
		wall2.position = new Vector2(mainCam.ViewportToWorldPoint(new Vector3(0.5f, 0,0)).x, mainCam.ViewportToWorldPoint(new Vector3(0, 0, 0)).y);
		goal1.position = new Vector2(mainCam.ViewportToWorldPoint(new Vector3(0,0,0)).x, mainCam.ViewportToWorldPoint(new Vector3(0, 0.5f, 0)).y);
		goal2.position = new Vector2(mainCam.ViewportToWorldPoint(new Vector3(1f,0,0)).x, mainCam.ViewportToWorldPoint(new Vector3(0, 0.5f, 0)).y);
		midline.position = new Vector2(mainCam.ViewportToWorldPoint(new Vector3(0.5f,0,0)).x, mainCam.ViewportToWorldPoint(new Vector3(0, 0.5f, 0)).y);


		for(int i = 0; i < balls.Length; i++){
			balls[i].transform.position = new Vector2(mainCam.ViewportToWorldPoint(new Vector3(0.5f, 0,0)).x, mainCam.ViewportToWorldPoint(new Vector3(0, 0.5f, 0)).y);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
