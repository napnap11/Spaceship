using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveriderController : MonoBehaviour {
	// Use this for initialization
	float speed = 10;
	public GameObject myBullet;
	public GameObject myEnemySpawn;
	public int HP = 5;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (HP <= 0) {
			this.gameObject.GetComponent<BoxCollider> ().enabled = false;
			this.gameObject.GetComponent<Renderer> ().enabled = false;
			myEnemySpawn.SetActive (false);
		} else {
			float move = Input.GetAxis ("Horizontal");
			transform.Translate (new Vector3 (move * Time.deltaTime * speed, 0.0f, 0.0f));
			if (transform.position.x > 13.75)
				transform.Translate (new Vector3 (-27.5f, 0.0f, 0.0f));
			if (transform.position.x < -13.75)
				transform.Translate (new Vector3 (27.5f, 0.0f, 0.0f));
			if (Input.GetKeyDown (KeyCode.Space)) {
				Instantiate (myBullet, this.gameObject.transform.position, Quaternion.identity);
			}
		}
	}
	GUIStyle gs = new GUIStyle();
	void OnGUI(){
		gs.fontSize = 50;
		gs.normal.textColor = Color.white;
		if(HP>0)
		GUI.Label (new Rect (10, 10, 1000, 1000), "HP: "+HP,gs);
		else GUI.Label (new Rect (10, 10, 1000, 1000), "GAME OVER",gs);
	}
}
