using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyController : MonoBehaviour {
	public GameObject aEnemy;
	// Use this for initialization
	void Start () {
		StartCoroutine(SpawnEnemy());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	float min = 1f;
	float max = 2f;
	IEnumerator SpawnEnemy(){
		while (true) {
			float waittime = Random.Range (min, max);
			if(max>=0.5f)max -= 0.01f;
			if(min>=0.1f)min -= 0.01f;

			float shift = Random.Range (-12f, 12f);
			Vector3 loc = new Vector3 (transform.position.x+shift, transform.position.y, transform.position.z);
			Instantiate (aEnemy, loc, Quaternion.identity);
			yield return new WaitForSeconds (waittime);
		}
	}
}
