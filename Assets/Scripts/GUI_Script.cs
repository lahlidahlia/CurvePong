using UnityEngine;
using System.Collections;

public class GUI_Script : MonoBehaviour {
	//public GUIStyle GUI_P1_style;
	//public GUIStyle GUI_P2_style;
	public Transform GUI_P1;
	public Transform GUI_P2;
	public Camera mainCam;

	ScoreScript scoreScript;
	void Start(){
		scoreScript = GetComponent<ScoreScript>();
		GUI_P1 = transform.Find("GUI_P1Score");
		GUI_P2 = transform.Find("GUI_P2Score");

	}
	void Update(){
        GUI_P1.guiText.text = scoreScript.player2Score.ToString();
        GUI_P2.guiText.text = scoreScript.player1Score.ToString();
	}

	/*void OnGUI () {
		//GUI.Box(new Rect(mainCam.ViewportToScreenPoint(new Vector3(0.3f, 0, 0)).x, mainCam.ViewportToScreenPoint(new Vector3(0, 0.5f, 0)).y, 100, 100), scoreScript.player2Score.ToString(), GUI_P1_style);
		//GUI.Box(new Rect(mainCam.ViewportToScreenPoint(new Vector3(0.7f, 0, 0)).x, mainCam.ViewportToScreenPoint(new Vector3(0, 0.5f, 0)).y, 100, 100), scoreScript.player1Score.ToString(), GUI_P1_style);

	}*/
}
