using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
	}

	public void startGame(string scene){
		
		Application.LoadLevel (scene);
	}

	public void Quit(){
	
		Application.Quit ();
	}
}
