using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject.FindGameObjectWithTag ("mainPiano").GetComponentInChildren<Text> ().text = "Piano";
		GameObject.FindGameObjectWithTag ("mainChaos").GetComponentInChildren<Text> ().text = "Chaos";
		GameObject.FindGameObjectWithTag ("mainAbout").GetComponentInChildren<Text> ().text = "About";
		GameObject.FindGameObjectWithTag ("goback").GetComponentInChildren<Text> ().text = "Home";
		HideAboutPanel ();
	}

	// Initially hide the information panel
	void HideAboutPanel()
	{
		GameObject.FindGameObjectWithTag ("mainPanel").GetComponent<CanvasGroup> ().alpha = 1f;
		GameObject.FindGameObjectWithTag ("aboutPanel").GetComponent<CanvasGroup> ().alpha = 0f;

		GameObject.FindGameObjectWithTag ("aboutPanel").GetComponent<CanvasGroup> ().blocksRaycasts = false;
		GameObject.FindGameObjectWithTag ("mainPanel").GetComponent<CanvasGroup> ().blocksRaycasts = true;

	}

	// Show the 'About' panel
	void ShowAboutPanel()
	{
		GameObject.FindGameObjectWithTag ("aboutPanel").GetComponent<CanvasGroup> ().alpha = 1f;
		GameObject.FindGameObjectWithTag ("mainPanel").GetComponent<CanvasGroup> ().alpha = 0f;

		GameObject.FindGameObjectWithTag ("aboutPanel").GetComponent<CanvasGroup> ().blocksRaycasts = true;
		GameObject.FindGameObjectWithTag ("mainPanel").GetComponent<CanvasGroup> ().blocksRaycasts = false;


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

	// Show About Page
	public void ShowAbout()
	{
		ShowAboutPanel ();
	}

	// Show main panel
	public void ReturnHome(){
		HideAboutPanel ();
	}
}
