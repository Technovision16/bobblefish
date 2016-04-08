
using UnityEngine;
using System.Collections;



public class FishController : MonoBehaviour {

	public float carSpeed;
	public float maxPos=-23.0f;
	public uiManager ui;

	Vector3 position;


	void Awake(){

	}

	void Start () {
			ui = GetComponent<uiManager> ();


		position = transform.position;

	}


	void Update () {
		position.x += Input.GetAxis ("Horizontal") * carSpeed * Time.deltaTime;
		position.x = Mathf.Clamp (position.x, -8.6f, 7.0f);
		position.y += Input.GetAxis ("Vertical") * carSpeed * Time.deltaTime;
		position.y = Mathf.Clamp (position.y, -3.9f, 4.0f);
		transform.position = position;

	}	
		void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "EnemyFish") 
			Destroy (gameObject);
		 ui.gameOverActivated();
			

	}
}

