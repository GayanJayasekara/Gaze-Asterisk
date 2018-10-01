using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {

	public Color colorStart = Color.cyan;
	public Color colorEnd = Color.blue;
	public float duration = 1.0F;
	public Renderer rend;

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();	
	}
	
	// Update is called once per frame
	void Update () {
		float lerp = Mathf.PingPong(Time.time, duration) / duration;
		rend.material.color = Color.Lerp(colorStart, colorEnd, lerp);
	}

	/*void onCollisionEnter (Collision col) {
		rend.material.color = Color.yellow;
	}*/
}
