using UnityEngine;
using System.Collections;

public class SphereScript : MonoBehaviour {
	
	private float initial;
	private GameObject _debugPointer;
	// Use this for initialization
	void Start () {
		initial = this.transform.position.y;
		_debugPointer = GameObject.FindGameObjectWithTag ("gazePointer");

		SetGazedAt (false);
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (_debugPointer.transform.position);
		Bounce();
		this.transform.Rotate (Vector3.up, Random.value * 2);
		if (this.GetComponent<AudioSource> ().isPlaying) {
			this.GetComponent<Light> ().intensity = 15;
		} else {
			this.GetComponent<Light>().intensity = 2.5f;
		}
	}

	//Bounce lightly to gain attention
	void Bounce()
	{
		float distance = .4f;
		float speed = 1.5f;
		float yBounce = initial + Mathf.Sin (Time.time * speed) * distance / 2.0f;
		this.transform.position = new Vector3 (this.transform.position.x,
		                                       yBounce,
		                                       this.transform.position.z);

	}

	public void SetGazedAt(bool gazedAt) {
		if (gazedAt) {
			Debug.Log ("Entered Gaze on " + this.gameObject.tag);
			this.GetComponent<AudioSource> ().Play ();

		}

		//GetComponent<Renderer>().material.color = gazedAt ? Color.green : Color.red;
	}
}
