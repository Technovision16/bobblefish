
using UnityEngine;
using System.Collections;



public class FishController : MonoBehaviour {
	public GameObject player2;

	public float carSpeed;
	public float maxPos=-23.0f;
	public uiManager ui;

	Vector3 position;
	bool currentPlatformAndroid=false;


	void Awake(){
		#if UNITY_ANDROID

			currentPlatformAndroid=true;
		
		#else
		currentPlatformAndroid=false;
		#endif

	}

	void Start () {
		///if (currentPlatformAndroid == true)
		//	Debug.Log ("Android");
	//	else
		//	Debug.Log ("Windows");
		
		ui= GetComponent<uiManager> ();


		position = transform.position;

	}


	void Update () {
		
		position.x += Input.acceleration.x  * carSpeed * Time.deltaTime;
		position.x = Mathf.Clamp (position.x, -8.6f, 7.0f);

		position.y += Input.acceleration.y * carSpeed * Time.deltaTime;
		position.y = Mathf.Clamp (position.y, -3.9f, 4.0f);
		transform.position = position;
	}

		
		//if (currentPlatformAndroid == true) {
			//COde

		void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "EnemyFish") {
			Destroy (player2);
		
			ui.gameOverActivated ();
		}


			

	}
}


