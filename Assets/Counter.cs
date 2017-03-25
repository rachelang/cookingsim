using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
			print ("tomato!");
			score++;
			col.gameObject.name = "noname";
		} else if (col.gameObject.name == "Cheese") {
			print ("cheese!");
			score++;
			col.gameObject.name = "noname";
		} else if (col.gameObject.name == "Lettuce") {
			print ("lettuce!");
			score++;
			col.gameObject.name = "noname";
		}

		if (score >= 3) {
			mc.goToLevel (2);
		}
	}
}
