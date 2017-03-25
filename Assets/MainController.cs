using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void goToLevel(int level){
		if (level == 2) {
			//setup level 2 of cooking burger
			//for now just change text
			GameObject.Find("instructions").GetComponent<Text>().text = "Nice!";
		}
	}
}
