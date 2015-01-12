using UnityEngine;
using System.Collections;

public class CubCollision : MonoBehaviour {
	public AudioClip collisionBox;
	public AudioClip destroyBox;
	public ParticleSystem boom;

	void OnCollisionEnter(Collision myCollision){
		string objectNameCollision = myCollision.gameObject.name;
		AudioSource.PlayClipAtPoint(collisionBox, transform.position);
		if (objectNameCollision.Contains ("prefab_bullet")) {
			AudioSource.PlayClipAtPoint(destroyBox, transform.position);
			Instantiate(boom,transform.position,transform.rotation);
			Destroy(this.gameObject);
		}
		//Debug.Log(objectNameCollision.ToString());
	}
}
