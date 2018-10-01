using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour {

	public Color colorStart = Color.red;
	public Color colorEnd = Color.yellow;
	public float duration = 1.0F;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		float lerp = Mathf.PingPong(Time.time, duration) / duration;


		Ray ray = new Ray (transform.position, transform.forward);
		RaycastHit hitInfo;


		if (Physics.Raycast(ray, out hitInfo)) {
			Debug.DrawLine(ray.origin, hitInfo.point, Color.red);
			//SetColor(hitInfo.collider.material, FF000A);
			
			

			if(hitInfo.collider.gameObject.tag == "HitTag") {
				print (hitInfo.collider.gameObject.name);
				//hitInfo.collider.gameObject.rend.material.ChangeColor(Color.yellow);
				hitInfo.collider.gameObject.GetComponent<MeshRenderer>().material.color = Color.Lerp(colorStart, colorEnd, lerp);
				//hitInfo.collider.gameObject.rend.material.color = Color.yellow;
			}

		} else {
			Debug.DrawLine(ray.origin, ray.origin + ray.direction * 100, Color.green);
		}

	}


}


/*
/// Changes the material attached to the gameObject
public static class ChangeMaterial(GameObject go, Material mat)
{
    go.renderer.material = mat;
}


/// Changes the color of the material
public static class ChangeColor(Material mat, Color color)
{
    mat.SetColor("_Color", color);              
}
*/
