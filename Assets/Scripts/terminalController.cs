using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class terminalController : MonoBehaviour {

	public string[] question = new string[]{"If an ice cube has a length width and depth of 6cm each and melts at 8 cubic cm per minute. How long would it take to melt?",
		"If a group of friends travel to Japan for 14 days and the cost of insurance is £26 p/p, but the insurance company gives them a 5% discount, what is the total end price?",
		"Calculate the volume of a cone with a height of 18cm and a diameter of 20cm. Remember V = 1/3Bh!",
		"What is the equation of the line passing through point (-2, 3) parallel to the line with the equation y + 4 x 7?"};
	public float[] answer = new float[]{1f,2f};

	public Text questionText;
	public Text headerText;
	public Text informationText;
	public Text footerText;
	public Text alertText;

	public bool isActive;


	public int terminalID = 1;
	public int questionN = 0;
	public GameObject terminalPanel;

	private Desk desk;

	//TODO get input from the player


	// Use this for initialization
	void Start () {
		//terminalPanel.SetActive (false);
		desk = GetComponent<Desk> ();
		isActive = false;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void startPanel()
	{
		//set terminal panel gameObject as active
		terminalPanel.SetActive(true);
		//Set the texts to mimic a PC booting up
		setTextsOnActive ();
	}

	public void deativatePanel()
	{
		clearAllTexts ();
		terminalPanel.SetActive (false);
		isActive = false;
	}

	//Clears all texts shown on the screen
	public void clearAllTexts()
	{
		questionText.text = "";
		headerText.text = "";
		footerText.text = "";
		informationText.text = "";
	}

	public void setTextsOnActive()
	{
		headerText.text = "Terminal ID "+terminalID+" is running boot start-up.";
		informationText.text = "";
		questionText.text = "";
		footerText.text = "LOADING BIOS PLEASE WAIT...";
		StartCoroutine ("sequence");
	}

	public void setTextsOnHack()
	{
		headerText.text = "File HAX.EXE has been mounted";
		informationText.text = "HAX.EXE running sequenceCrackerv12.4.bat";
		questionText.text = "";
		footerText.text = "LOADING BIOS PLEASE WAIT...";
	}

	public void setTextsOnQuestion()
	{
		questionText.text = question [questionN];
		informationText.text = "";
		footerText.text = "ERROR: SYSTEM.OVERRIDE = true;" +
			" Terminal ID "+terminalID+" attempting to connect...";
		StopCoroutine ("sequence");
	}

	public void calculateQuestion()
	{
		//TODO make system to chose the questions based on the game's difficulty level and level progression
	}

	public void enablePlayerInput()
	{
		//TODO allow player to input numbers (Number Keypad?)
	}

	public IEnumerator sequence()
	{
		while(true)
		{
			yield return new WaitForSeconds(3f);
			setTextsOnHack ();
			yield return new WaitForSeconds(3f);
			setTextsOnQuestion ();
		}
	}
		
}
