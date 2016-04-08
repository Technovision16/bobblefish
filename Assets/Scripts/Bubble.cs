using UnityEngine;
using System.Collections;

public class Bubble : MonoBehaviour {
	Vector3 position;

	// Use this for initialization
	void Start () {
		position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		position.y = Mathf.Clamp (position.y, -5f, 5.0f);
		transform.position = position;
	
	}
	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "EnemyFish") {
			Destroy (col.gameObject);

		}

	}
}
