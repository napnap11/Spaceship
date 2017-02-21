using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
	public AudioClip explode;
	// Use this for initialization
	public GameObject EnemyBullet;
	float speed;
	void Start () {
		speed = Random.Range (-2f, -12f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.up * Time.deltaTime * speed);
		if (transform.position.y <= -3f)
			Destroy (this.gameObject);
		float shootrate = Random.Range (1, 1000);
		if (shootrate > 980) {
			Instantiate (EnemyBullet, this.gameObject.transform.position, Quaternion.identity);
		}
	}
	void OnTriggerEnter(Collider other){
		this.gameObject.GetComponent<Collider> ().isTrigger = false;
		this.gameObject.GetComponent<Renderer> ().enabled = false;
		if (other.gameObject.GetComponent<WaveriderController> () != null) {
			this.gameObject.GetComponent<AudioSource> ().clip = explode;
			this.gameObject.GetComponent<AudioSource> ().Play ();
			other.gameObject.GetComponent<WaveriderController> ().HP--;
		}
	}
}
