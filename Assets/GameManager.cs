using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	public static GameManager instance = null;
	public GameObject scoreTextObject;
	public GameObject lifeTextObject;
	int score;
	int life = 3;
	Text scoreText;
	Text lifeText;
	void Awake(){
		DontDestroyOnLoad (scoreTextObject);

		if (instance == null)
			instance = this;
		else if(instance!= null)
			Destroy(gameObject);

		scoreText = scoreTextObject.GetComponent<Text> ();
		scoreText.text = "Score: " + score.ToString ();
		lifeText = lifeTextObject.GetComponent<Text> ();
		lifeText.text = "Life:" + life.ToString ();
	}

	public void Collect(int passedValue, GameObject passedObject){
		passedObject.GetComponent<Renderer> ().enabled = false;
		passedObject.GetComponent<Collider> ().enabled = false;
		Destroy (passedObject, 0.5f);
		score = score + passedValue;
		scoreText.text = "Score: " + score.ToString ();
		
	}

	public void decreaseLife(){
	
		life = life - 1;
		lifeText.text = "Life: " + life.ToString ();
	}

	public int getScore(){
	
		return score;
	}

}
