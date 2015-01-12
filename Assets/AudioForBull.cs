using UnityEngine;
using System.Collections;

public class AudioForBull : MonoBehaviour {

	public AudioClip myClip;

	// Use this for initialization
	void Start () {
		audio.PlayOneShot (myClip);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
