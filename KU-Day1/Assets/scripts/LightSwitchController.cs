using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitchController : MonoBehaviour {

	// Use this for initialization
	public GameObject light;
	public 
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnGUI(){
		if (GUI.Button (new Rect (Screen.width / 2 - 50, Screen.height / 2 - 50, 100, 100), light.GetComponent<Light> ().enabled?"Turn off":"Turn on")) {
			light.GetComponent<Light> ().enabled = !light.GetComponent<Light> ().enabled;
		}
	}
}
