using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemySpawner:MonoBehaviour  {

	public GameObject[] cars;
	private List<GameObject> enemies;
	float elapsed;
	float generationTime;
	float downLimit;
	float topLimit;
	void Start () {
        enemies = new List<GameObject>();
		string level = PlayerPrefs.GetString ("level");
		int index = 0;
		string carSelection = PlayerPrefs.GetString ("car");
		for (int i = 0; i < cars.Length*3; i++) {
			if (!cars [index].gameObject.name.Equals(carSelection)) {
				GameObject go = Instantiate(cars [index], transform.position, transform.rotation) as GameObject;		
				go.name = cars [index].gameObject.name;
				enemies.Add (go);
                go.SetActive(false);
            }
			index++;
			if (index == cars.Length) {
				index = 0;
			}
		}
		topLimit = 8f;
		downLimit = 2f;
		switch(level){
			case "medium":
			topLimit = 6f;
			break;
			case "hard":
			topLimit = 4f;
			break;
		}
		generationTime = Random.Range (downLimit, topLimit);
	}

    // Update is called once per frame
    void Update()
    {
        elapsed += Time.deltaTime;
        if (elapsed >= generationTime)
        {
            generationTime = Random.Range(downLimit, topLimit);
            generateEnemies();
            elapsed = 0f;
        }
    }

	void generateEnemies(){
		int random = Random.Range (0, enemies.Count);
		while (true) {
			if (!enemies [random].activeInHierarchy) {
				enemies [random].SetActive (true);
				enemies [random].transform.position = new Vector3 (Random.Range (-2f, 2f), transform.position.y, transform.position.z);	
				break;
			} else {
				random = Random.Range (0, enemies.Count);
			}
		}
	}
}
