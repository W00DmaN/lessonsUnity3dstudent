using UnityEngine;
using System.Collections;

public class cleanDestroyEffect : MonoBehaviour {
	private ParticleSystem ps;

	// Use this for initialization
	void Start () {
		ps = (ParticleSystem)GetComponent(typeof(ParticleSystem));
	}
	
	// Update is called once per frame
	void Update () {
		if (ps) {
			if (!ps.IsAlive ()) {
					Destroy (gameObject);
			}
		}
	}
}
