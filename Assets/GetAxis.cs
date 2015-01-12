using UnityEngine;
using System.Collections;

public class GetAxis : MonoBehaviour {

	private float horiz;
	private float vertic;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		horiz = Input.GetAxis("Horizontal");
		//Debug.Log(horiz);
		transform.Rotate (new Vector3(0.0f, horiz, 0.0f));
		vertic = Input.GetAxis ("Vertical");
		transform.Translate (new Vector3 (vertic, 0.0f, 0.0f));
		//transform.Translate(new Vector3(horiz, 0.0f, 0.0f));
	}
}
