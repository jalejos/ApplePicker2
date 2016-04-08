using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ApplePickerScript : MonoBehaviour {

	int score;
	public Text scoreUI;

	// Use this for initialization
	void Start () {
		score = 0;
		scoreUI.text = score.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AppleCatched () {
		score += 100;
		scoreUI.text = score.ToString();
	}
}
