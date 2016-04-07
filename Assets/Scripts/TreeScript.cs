using UnityEngine;
using System.Collections;

public class TreeScript : MonoBehaviour {
	
	public float speed;
	public float limit;
	public float chanceOfChange;
	public float chanceOfSpawn;
	public GameObject appleObject;
	bool movingLeft;

	void Update () {
		Vector3 pos = this.transform.position;

		if (movingLeft) {
			pos.x -= speed * Time.deltaTime;
			this.transform.position = pos;
		} else {
			pos.x += speed * Time.deltaTime;
			this.transform.position = pos;
		}


	}

	void FixedUpdate () {
		Vector3 pos = this.transform.position;

		if (pos.x >= limit || pos.x <= -limit || Random.Range(0f,1f) <= chanceOfChange)  {
			movingLeft = !movingLeft;
		}

		if (Random.Range (0f, 1f) <= chanceOfSpawn) {
			Instantiate (appleObject, pos, Quaternion.identity);
		}
	}

}
