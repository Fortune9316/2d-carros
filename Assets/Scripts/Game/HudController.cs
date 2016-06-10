using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HudController : MonoBehaviour
{

    // Use this for initialization
    public Text scoreTxt, lifeTxt;
    public int life = 3;
    float score;
    public static HudController instance;
    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        lifeTxt.text = "Life : " + life;
        scoreTxt.text = "Score :" + score;
    }

    void Update()
    {
        score += Time.deltaTime;
        scoreTxt.text = "Score :"+ score;
    }

    public void reduceLife()
    {
        life--;
        lifeTxt.text = "Life : " + life;
        if (life == 0)
        {
            PlayerPrefs.SetFloat("score", score);
            SceneManager.LoadScene("GameOver");
        }
    }
}		
		

