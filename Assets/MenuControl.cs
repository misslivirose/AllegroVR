using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject.FindGameObjectWithTag ("mainPiano").GetComponentInChildren<Text> ().text = "Piano";
		GameObject.FindGameObjectWithTag ("mainChaos").GetComponentInChildren<Text> ().text = "Chaos";
		GameObject.FindGameObjectWithTag ("mainAbout").GetComponentInChildren<Text> ().text = "About";

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// We want to load in the scene for the piano tones
	public void LoadPiano(){
	}

	// Load in Chaos scene
	public void LoadChaos(){
		Application.LoadLevel ("Synethesia");
	}
	
}
