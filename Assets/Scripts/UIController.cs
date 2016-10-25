using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIController : MonoBehaviour {

	public Text alertText;
	public Text objectiveText;
	public string[] currentObjective = {"Find out what is going on.", "Find a way to unlock the door", 
		"Hack the Terminal", "Get to the bridge","Find a way to stop the collision" , "Get to an escape pod", "Investigate the area"};
	//Used to control what message from the array is shown as objective text
	public int currentObjectiveN = 0;

	public string[] currentAlert = {"", "Use the WASD keys to move", "Press the SPACEBAR to jump", "Hold SHIFT key to sprint", 
		"Interact with a terminal with the E key", "The spaceship is on a collision course with a star", " Minutes until collision"};
	public int currentAlertN = 0;

		


	// Use this for initialization
	void Start () {
		
		setTexts ();
		updateObjectiveText ();
		updateAlertText ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Sets texts to there default states
	void setTexts()
	{
		alertText.text = "";
		objectiveText.text = currentObjective [currentObjectiveN];
	}

	//Update the objective text (Top left corner in game)
	void updateObjectiveText()
	{
		objectiveText.text = currentObjective [currentObjectiveN];
	}

	//Update the alert text (Just below center of screen in game)
	void updateAlertText()
	{
		alertText.text = currentAlert [currentAlertN];
	}
}
