using UnityEngine;
using System.Collections;

public class teleport : MonoBehaviour {

	public Transform destino;
	bool delantepuerta = false;
	bool teletransporta = false;

	void Update(){

		if (Input.GetKeyDown (KeyCode.V)&& delantepuerta){
			teletransporta = true;
		}
	}

	// Use this for initialization
	void OnTriggerEnter2D(Collider2D target){
		if (target.transform.tag == "Player")
			delantepuerta = true;

	}

	void OnTriggerStay2D(Collider2D target){

		if (teletransporta) {
			target.transform.position = destino.position;
			teletransporta = false;
		}
	}

	void OnTriggerExit2D(Collider2D target){
		if (target.transform.tag == "Player")
			delantepuerta = false;
	}

	void OnDrawGizmos(){
		if (destino != null){
			Gizmos.color = Color.blue;
			Gizmos.DrawLine(transform.position,  destino.position);

	 }
}
}