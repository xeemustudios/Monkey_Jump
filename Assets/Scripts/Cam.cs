using UnityEngine;
using System.Collections;

public class Cam : MonoBehaviour {
	public Transform target;
	public float distance;

	void FixedUpdate () {
		transform.position = new Vector3(transform.position.x, transform.position.y- distance, transform.position.z );
		//transform.LookAt(target);
	}
}
