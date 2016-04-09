using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class uiManager : MonoBehaviour {
	public Rigidbody2D projectile;
	public float speed = 20;
	//public GameObject pauseUi;
	public Button[] buttons;
	public Text scoreText;
	int score;
	bool gameOver;
	// Use this for initialization
	void Start () {
		gameOver = true;
		int score = 0;
		InvokeRepeating ("scoreUpdate", 3.0f, 1.5f);
	}

	void scoreUpdate(){
		if(gameOver == true)
		score+=1;
		}

	
	// Update is called once per frame
			void Update () {
		scoreText.text = "SCORE " + score;
	

	}
	public void Play(){
		//Application.LoadLevel (1);
		SceneManager.LoadScene ("scene1");
	}
		public void gameOverActivated(){
			gameOver = false;
				foreach(Button button  in buttons){
					button.gameObject.SetActive(true);
				}
			}

	public void Pause(){
		if (Time.timeScale == 1) {
			Time.timeScale = 0;
		}
		else if (Time.timeScale == 0){
			Time.timeScale = 1;
		}

	}
	public void shoot()
	{

		Rigidbody2D instantiatedProjectile = Instantiate(projectile,
			transform.position,
			transform.rotation)
			as Rigidbody2D;

		instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(speed, 0,0));

	}
	//public void menu(){
	//	Application.LoadLevel ("scene1");
	//}
	public void exit(){
		Application.Quit ();
	}
}
