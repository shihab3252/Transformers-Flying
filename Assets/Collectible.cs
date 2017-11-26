using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour {

	public int value;
	public float rotateSpeed;


	void Start(){
		Debug.Log ("collectible script added to" + gameObject.name);
	}
	// Update is called once per frame
	void Update () {
		transform.Rotate (0, 5, 0, Space.World);
	}

	public void OnTriggerEnter(){
			 
		GameManager.instance.Collect (value, gameObject);
			AudioSource source = GetComponent<AudioSource> ();
			source.Play ();

	}
}
