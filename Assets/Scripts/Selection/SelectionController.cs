using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectionController:MonoBehaviour
{

    // Use this for initialization
    public Button easy, medium, hard;
    void Start()
    {
        easy.onClick.AddListener(()=> selection("easy"));
        medium.onClick.AddListener(() => selection("medium"));
        hard.onClick.AddListener(() => selection("hard"));
    }

    void selection(string level)
    {
        PlayerPrefs.GetString("level", level);
        SceneManager.LoadScene("Game");
    }
}

