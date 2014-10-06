using UnityEngine;
using System.Collections;

public class GoalScript : MonoBehaviour {
	public Transform GM;

	public bool isGoal1 = true;

	ScoreScript scoreScript;

	void Start(){
		scoreScript = GM.gameObject.GetComponent<ScoreScript>();
	}
	void OnCollisionEnter2D(Collision2D collision){
		if(collision.gameObject.tag == "Ball"){
			if(isGoal1){
				scoreScript.player1Score++;
			}
			else{
				scoreScript.player2Score++;
			}
		}
	}
}
