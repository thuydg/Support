using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TestButtonClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Button button = (Button)this.GetComponent<Button> ();
		button.onClick.AddListener (() => {
			Debug.Log("Clicked");
			Application.LoadLevel("Base");
		});

	}
	
	// Update is called once per frame
	void Update () {
	
	}

//	public void ClickTest() {
//		Debug.Log ("Clicked");
//	}
}
