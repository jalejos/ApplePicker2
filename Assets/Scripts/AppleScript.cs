using UnityEngine;
using System.Collections;

public class AppleScript : MonoBehaviour {

	public float bottomLimit;
	public ApplePickerScript script;

	// Use this for initialization
	void Start () {
		script = Camera.main.GetComponent<ApplePickerScript> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate () {
		Vector3 pos = this.transform.position;
		if (pos.y <= bottomLimit) {
			Destroy (this.gameObject);
		}
	}

	void OnCollisionEnter (Collision col){
		if (col.gameObject.tag == "Basket") {
			script.AppleCatched ();
			Destroy (this.gameObject);
		}
	}
}
