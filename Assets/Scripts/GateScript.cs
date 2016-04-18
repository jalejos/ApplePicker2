using UnityEngine;
using System.Collections;

public class GateScript : MonoBehaviour {

	GameObject obstacle;

	void OnMouseEnter (){
		this.transform.FindChild("GateObstacle").gameObject.SetActive (false);
	}

	void OnMouseExit() {
		this.transform.FindChild("GateObstacle").gameObject.SetActive (true);
	}
}
