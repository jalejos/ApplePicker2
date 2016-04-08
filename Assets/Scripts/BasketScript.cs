using UnityEngine;
using System.Collections;

public class BasketScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate () {
		Vector3 mouse = Input.mousePosition;
		Vector3 mousePos = Camera.main.ScreenToWorldPoint (mouse);
		Vector3 pos = this.transform.position;
		pos = new Vector3 (mousePos.x, pos.y, pos.z);
		this.transform.position = pos;
	}
		
}
