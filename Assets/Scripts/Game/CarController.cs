using UnityEngine;
using System.Collections;

public class CarController:MonoBehaviour  {

	Rigidbody2D body;
	bool isEnemy;
	string carSelection;
	float enemySpeed;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        string level = PlayerPrefs.GetString("level", "easy");
        carSelection = PlayerPrefs.GetString("car");
        if (carSelection == gameObject.name)
        {
            isEnemy = false;
        }
        else {
            isEnemy = true;
            transform.localScale = new Vector3(1f, -1f, 1f);
            enemySpeed = 4f;
            switch (level)
            {
                case "medium":
                    enemySpeed = 3f;
                    break;
                case "hard":
                    enemySpeed = 2f;
                    break;
            }
        }
    }

	void Update () {
		if (!isEnemy) {
			float forceX = 0;
			if (Input.GetKey (KeyCode.LeftArrow)) {
				forceX = -4f;
			}
			if (Input.GetKey (KeyCode.RightArrow)) {
				forceX = 4f;
			}
			body.velocity = new Vector2 (forceX, body.velocity.y);
		} else {
			body.velocity = new Vector2 (body.velocity.x, -enemySpeed);
		}
	}

	void OnTriggerEnter2D(Collider2D coll){
		if (coll.gameObject.tag == "dead") {
			gameObject.SetActive (false);
		} else {
			
			if (!isEnemy) {
                
                HudController.instance.reduceLife();
			}
		}
	}
}
