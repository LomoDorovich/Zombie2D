using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {
	public string nombreNivel;

	public void salir(){
		Application.Quit ();
	}
	public void jugar(){
		Application.LoadLevel (nombreNivel);

	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
