using UnityEngine;
using System.Collections;

public class DeadScrit : MonoBehaviour {
	bool GameOver;
	// Use this for initialization
	void Start () {
		GameOver = false;
	}
	void OnCollisionEnter2D(Collision2D coll) {
		
		if (coll.gameObject.tag.Equals ("Player")) {
			GameOver = true;
			Debug.Log("GameOver");
			coll.gameObject.SetActive(false);

		}
		if (coll.gameObject.tag.Equals ("ground")) {
			GameOver = true;
			Debug.Log("GameOver");
			coll.gameObject.SetActive(false);
		}
	}
	void OnGUI(){
		GUI.Label( (new Rect(10f , (Screen.height)-40, 260, 180)), "Space for Jump");
		GUI.Label( (new Rect(10f , (Screen.height)-20, 260, 180)), "Arrow keys for Left and Right");
		if (GameOver) {
			GUI.Label( (new Rect((Screen.width/2)+10f , (Screen.height/2)-60, 260, 180)), "GAME OVER");
			if (GUI.Button (new Rect ((Screen.width / 2) +10f, (Screen.height / 2) - 140, 100, 50), "PLAY")) {
				Application.LoadLevel ("main");
			}
			if (GUI.Button (new Rect ((Screen.width / 2) +10f, (Screen.height / 2) - 10, 100,50), "EXIT")) {

			}	

			
		}
		
		
	}
}
