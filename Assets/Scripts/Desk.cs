using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Desk : MonoBehaviour {

	public bool isOpen;

	public Text alertText;

	public enum State{
		Open,
		Closed,
		Inbetween
	}

	public State state;

	// Use this for initialization
	void Start () {
		state = Desk.State.Closed;
		isOpen = false;

	}

	// Update is called once per frame
	void Update () {

	}

	public void OnMouseEnter(){

		alertText.text = "Press RMB to load HAX.EXE";
		Debug.Log ("Enter");
	}

	public void OnMouseExit () {
		alertText.text = "";
		Debug.Log ("Exit");
	}

	public void OnMouseUp (){
		Debug.Log ("Up");
	}

	private void Open (){
		Debug.Log ("Open");
	}

	private void Close (){
		Debug.Log ("Close");
	}
}
