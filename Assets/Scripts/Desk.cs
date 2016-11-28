using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Desk : MonoBehaviour {

	public bool isOpen;

	public Text alertText;
	public terminalController terminalcontroller;

	// Use this for initialization
	void Start () {
		terminalcontroller = GetComponent<terminalController> ();
		isOpen = false;

	}

	// Update is called once per frame
	void Update () {

	}

	public void OnMouseEnter(){

		alertText.text = "Press LMB to load Terminal with HAX.EXE";
		Debug.Log ("Enter");
	}

	public void OnMouseExit () {
		alertText.text = "";
		Debug.Log ("Exit");
	}

	public void OnMouseUp (){
		Debug.Log ("Up");
		alertText.text = "";
		terminalcontroller.startPanel();
	}

	private void Open (){
		Debug.Log ("Open");
	}

	private void Close (){
		Debug.Log ("Close");
	}
}
