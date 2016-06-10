using UnityEngine;
using System.Collections;


public class Looper:MonoBehaviour  {

	// Use this for initialization
	Material mat;
	Vector3 offset;
	public float speed = 2f;
	void Start () {
		mat = GetComponent<Renderer> ().material;
		offset = mat.GetTextureOffset ("_MainTex");
	}

	void Update () {
		offset.y += speed* Time.deltaTime;
		mat.SetTextureOffset ("_MainTex",offset);
	}
}
