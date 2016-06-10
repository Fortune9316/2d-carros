using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChooserController :MonoBehaviour {

	// Use this for initialization
	public Button[] cars;
	void Start () {
        for (int i = 0; i < cars.Length; i++)
        {
            Button btn = cars[i].GetComponent<Button>();
            string name = cars[i].gameObject.name;
            btn.onClick.AddListener(() => pickCar(name));           
        }
	}
	
	void pickCar(string carname){
        for (int i = 0; i < cars.Length; i++) {
            cars[i].onClick.RemoveAllListeners();
                }
		
		PlayerPrefs.SetString ("car", carname);
		SceneManager.LoadScene("LevelSelection");

	}
}
