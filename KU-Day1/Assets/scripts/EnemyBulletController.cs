using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletController : MonoBehaviour {
	public AudioClip explode;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.down * Time.deltaTime * 20f);
		if (transform.position.y <= -13f)
			Destroy (this.gameObject);
	}
	void OnTriggerEnter(Collider other){
		this.gameObject.GetComponent<Collider> ().isTrigger = false;
		this.gameObject.GetComponent<Renderer> ().enabled = false;
		if (other.gameObject.GetComponent<WaveriderController> () != null) {
			this.gameObject.GetComponent<AudioSource>().clip = explode;
			this.gameObject.GetComponent<AudioSource> ().Play ();
			other.gameObject.GetComponent<WaveriderController> ().HP--;
		}
	}
}
