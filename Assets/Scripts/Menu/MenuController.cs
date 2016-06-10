using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController:MonoBehaviour {

    public Button btnStart;
    void Start() {
        
        btnStart.onClick.AddListener(() => startGame());

    }

    void startGame() {
        btnStart.onClick.RemoveAllListeners();

        SceneManager.LoadScene("Chooser");
    }
}

