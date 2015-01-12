using UnityEngine;
using System.Collections;

public class PlayerGun : MonoBehaviour {
	public int bulletImpulse = 300;
	public float shootSpeed = 1.0F; 
	public GameObject bullet; 
	private float lastShotTime ; 
	public AudioClip myClip;
	
	// Use this for initialization
	void Start () {
		lastShotTime = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Mouse0)) {
			if (Time.time>(lastShotTime + shootSpeed)) {
				GameObject bull_clone = (GameObject)Instantiate(bullet, transform.position, transform.rotation); 
				Physics.IgnoreCollision(bull_clone.collider, collider); 
				bull_clone.rigidbody.AddForce(transform.forward*bulletImpulse, ForceMode.Impulse); lastShotTime = Time.time;
				AudioSource.PlayClipAtPoint(myClip, transform.position);
			}
		}
	}


}
