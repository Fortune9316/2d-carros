using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverController:MonoBehaviour {


	public Text txtScore;
	public Button restart, menu;
	// Use this for initialization
	void Start () {
		restart.onClick.AddListener (()=> goRestart ());
		menu.onClick.AddListener(()=> goMenu ());
		txtScore.text = "Score :" + PlayerPrefs.GetFloat("score", 0);
	}

	void goRestart(){
        restart.onClick.RemoveAllListeners();
		SceneManager.LoadScene ("Game");
	}

	void goMenu(){
		menu.onClick.RemoveAllListeners();
        SceneManager.LoadScene("Menu");
	}

}
