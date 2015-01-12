using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour {

	public string myLevel;

	void OnCollisionEnter (Collision myCollision)
	{
		if (myCollision.gameObject.name == "prefab_bullet(Clone)")
		{
			Application.LoadLevel(myLevel);
		} 
	}
}
