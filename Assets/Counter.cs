using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour {

	private MainController mc;
	private int score = 0;

	// Use this for initialization
	void Start () {
		mc = GameObject.Find ("mainController").GetComponent<MainController> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.name == "Tomato") {
			GameObject.Find("instructions").GetComponent<Text>().text = "Tomato placed!";
			score++;
			col.gameObject.name = "noname";
		} else if (col.gameObject.name == "Cheese") {
			GameObject.Find("instructions").GetComponent<Text>().text = "Cheese placed!";
			score++;
			col.gameObject.name = "noname";
		} else if (col.gameObject.name == "Lettuce") {
			GameObject.Find("instructions").GetComponent<Text>().text = "Lettuce placed!";
			score++;
			col.gameObject.name = "noname";
		}

		if (score >= 3) {
			mc.goToLevel (2);
		}
	}
}
