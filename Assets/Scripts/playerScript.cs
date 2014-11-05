using UnityEngine;
using System.Collections;

public class playerScript : MonoBehaviour {

	public float speed = 10f;
	public Vector2 maxVelocity = new Vector2(2,3);


	
	void Start () {
	
		//animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		var absVelX = Mathf.Abs (rigidbody2D.velocity.x);
		var forceX = 0f;
		var forceY = 0f;

		//Calculate Velocity X
		if (Input.GetKey ("right")) {
						if (absVelX < maxVelocity.x)
								forceX = speed;
						this.transform.localScale = new Vector3 (1, 1, 1);
				} else if (Input.GetKey ("left")) {
						if (absVelX < maxVelocity.x)
								forceX = -speed;
						this.transform.localScale = new Vector3 (-1, 1, 1);
				}
			rigidbody2D.AddForce (new Vector2(forceX, forceY));

	}
		
}