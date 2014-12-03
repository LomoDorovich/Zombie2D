using UnityEngine;
using System.Collections;

public class nextlevel : MonoBehaviour {

	public string nombreNivel;
	bool cargando = false;
	float tiempoEspera = 3f;

	void OnTriggerStay2D(Collider2D target) {
		if (target.transform.tag == "Player") {
			Application.LoadLevel (nombreNivel);
	// Use this for initialization
		}
	}
	void OnTriggerEnter2D(Collider2D target){
				cargando = true;
		}
	void OnTriggerExit2D(Collider2D target){
				cargando = false;

		}
	IEnumerator cargaNivel(){
				cargando = true;
				yield return new WaitForSeconds(tiempoEspera);
				if(cargando)
			Application.LoadLevel(nombreNivel);
		}
}
