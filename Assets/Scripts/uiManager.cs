using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class uiManager : MonoBehaviour {
	//public Button[] buttons;
	public Text scoreText;
	int score;
	bool gameOver;
	// Use this for initialization
	void Start () {
		gameOver = false;
		int score = 0;
		InvokeRepeating ("scoreUpdate", 3.0f, 1.5f);
	}

	void scoreUpdate(){
		if(gameOver == false)
		score+=1;
		}
	
	
	// Update is called once per frame
			void Update () {
		scoreText.text = "SCORE " + score;
	

	}
	//public void Play(){
	//	Application.LoadLevel ("scene1");
	//}
		public void gameOverActivated(){
			gameOver = true;
	//			foreach(Button button  in buttons){
	//				button.gameObject.SetActive(true);
				}
	//		}

	//public void Pause(){
	//	if (Time.timeScale == 1) {
	///		Time.timeScale = 0;
	//	}
	//	else if (Time.timeScale == 0){
	//		Time.timeScale = 1;
	//	}
	//}
}
