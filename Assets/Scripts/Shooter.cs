using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {
	public GameObject player;
	public GameObject shootbuton;

	public Rigidbody2D projectile;

	public float speed = 20;



	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown("space"))
		{
			Rigidbody2D instantiatedProjectile = Instantiate(projectile,
				transform.position,
				transform.rotation)
				as Rigidbody2D;

			instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(speed, 0,0));

		}
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Bubble") {
			shootbuton.SetActive (false);
			Destroy (player);

			//ui.gameOverActivated ();
		}




	}
}