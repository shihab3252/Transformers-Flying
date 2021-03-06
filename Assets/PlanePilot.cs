using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanePilot : MonoBehaviour {
	public float speed = 40.0f;
	GameManager score;

	// Use this for initialization
	void Start () {
		//Debug.Log ("Plane pilot script added to" + gameObject.name);
	}

	// Update is called once per frame
	void Update () {
		Vector3 moveCamTo = transform.position - transform.forward * 10.0f + Vector3.up * 5.0f ;
		float bias = 0.96f;
		transform.position += transform.forward * Time.deltaTime * speed;
		Camera.main.transform.position = Camera.main.transform.position * bias + moveCamTo * (1.0f - bias);
		Camera.main.transform.LookAt (transform.position + transform.forward * 30f);
		speed -= transform.forward.y * Time.deltaTime *  50.0f; 

		if (speed < 20.0f) {
			speed = 20.0f;
		}
		if (speed > 50.0f) {
			speed = 50.0f;
		}


		transform.Rotate (Input.GetAxis ("Vertical"), 0.0f , -Input.GetAxis("Horizontal"));

		float terrainHeightWhereWeAre = Terrain.activeTerrain.SampleHeight (transform.position);
		if (terrainHeightWhereWeAre > transform.position.y) {
			GameManager.instance.decreaseLife ();
			Application.LoadLevel (2);
			transform.position = new Vector3 (transform.position.x,
				terrainHeightWhereWeAre, transform.position.z);
		}

		if (score.getScore () == 600) {
			Application.LoadLevel (2);

		}
	}
}
