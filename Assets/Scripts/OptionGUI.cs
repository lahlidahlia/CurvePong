using UnityEngine;
using System.Collections;

public class OptionGUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI() {
        Global.player1_mouse = GUI.Toggle(new Rect(Screen.width / 2 - 200, Screen.height / 2, 150, 50), Global.player1_mouse, "Player 1 Mouse");
        Global.player2_mouse = GUI.Toggle(new Rect(Screen.width / 2 + 200, Screen.height / 2, 150, 50), Global.player2_mouse, "Player 2 Mouse");
    }
}
