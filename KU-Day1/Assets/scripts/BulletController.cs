	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public class BulletController : MonoBehaviour {
		public AudioClip explode;
		// Use this for initialization
		void Start () {
			
		}
		
		// Update is called once per frame
		void Update () {
			transform.Translate (Vector3.up * Time.deltaTime * 20f);
			if (transform.position.y >= 30f)
				Destroy (this.gameObject);
		}

		void OnTriggerEnter(Collider other){
			this.gameObject.GetComponent<AudioSource>().clip = explode;
			this.gameObject.GetComponent<AudioSource> ().Play ();
			this.gameObject.GetComponent<Collider> ().isTrigger = false;
			this.gameObject.GetComponent<Renderer> ().enabled = false;
			this.gameObject.GetComponent<Rigidbody> ().detectCollisions = false;
			Destroy (other.gameObject);
		}
	}
