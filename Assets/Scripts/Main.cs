using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {
	public Texture R_arrow;
	public Texture L_arrow;
	public Texture Jump;
	public float MaxSpeed =10f;
	bool facingRight = true;
    bool grounded =false;
	public Transform groundCheck;
	float groundRadius= 0.2f;
	public LayerMask whatisground;
	Animator anim;
	//int attackHash = Animator.StringToHash("cong_attack");
	int runStateHash;
	//Vector2 startpo
	float move;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();

	}
	void FixedUpdate(){
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatisground);
		anim.SetBool ("Ground", grounded);


		 move=Input.GetAxis("Horizontal");
		anim.SetFloat ("Speed", Mathf.Abs (move));
		rigidbody2D.velocity = new Vector2 (move * MaxSpeed, rigidbody2D.velocity.y);



		if (move > 0 && !facingRight)
						flip ();
		else if(move<0 && facingRight)
			flip();

		}
	void flip(){
		facingRight = !facingRight;
		Vector3 thescale = transform.localScale;
		thescale.x *= -1;
		transform.localScale = thescale;

		}
	// Update is called once per frame
	void Update () {

		if (grounded && Input.GetKeyDown (KeyCode.Space)) {
			anim.SetBool("Ground",false);
			anim.SetBool("Jump",true);
			rigidbody2D.AddForce(new Vector2(0,1200f));

				} 

	}

	void OnGUI(){


		
		
	}
	


}

