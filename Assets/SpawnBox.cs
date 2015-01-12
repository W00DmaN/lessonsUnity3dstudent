using UnityEngine;
using System.Collections;

public class SpawnBox : MonoBehaviour {

	public GameObject spawnObject;
	private bool readySpawn = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (readySpawn) {
			StartCoroutine (spawnObjects());
		}
	}

	private IEnumerator spawnObjects(){
		readySpawn = false;
		Instantiate (spawnObject, transform.position, transform.rotation);
		yield return new WaitForSeconds (2);
		readySpawn = true;

	}

}
