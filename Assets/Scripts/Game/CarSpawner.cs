using UnityEngine;
using System.Collections;

public class CarSpawner :MonoBehaviour {

	// Use this for initialization
	public GameObject[] cars;
	void Start () {
		string carSelection = PlayerPrefs.GetString ("car");
		for (int i = 0; i < cars.Length; i++) {
			if (cars [i].gameObject.name.Equals(carSelection)) {
				GameObject go =  Instantiate (cars [i], transform.position, transform.rotation) as GameObject;
				go.name = cars [i].name;
				break;
			}
		}
	}
}
