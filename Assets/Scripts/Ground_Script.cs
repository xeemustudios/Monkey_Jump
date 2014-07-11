using UnityEngine;
using System.Collections;

public class Ground_Script : MonoBehaviour {
	public GameObject Player;
	float translation,translationy;
	bool a =false;

	void FixedUpdate () {
		translation = -Time.deltaTime *5;
		translationy = Time.deltaTime *(2);
	}

	void OnCollisionEnter2D(Collision2D coll) 
	{
		if (coll.gameObject.tag.Equals ("Player")) {
		gameObject.transform.Translate (0, translation, 0);
				                                    }
		}

	void OnGUI(){
		if (gameObject.transform.localPosition.y < 0) {
						if (Player.transform.localPosition.y > (1.9)) {
								gameObject.transform.Translate (0, translationy, 0);
						}
				}
	}
}
