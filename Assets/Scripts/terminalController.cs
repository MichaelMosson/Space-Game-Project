using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class terminalController : MonoBehaviour {

	public string[] question = new string[]{"If an ice cube has a length width and depth of 6cm each and melts at 8 cubic cm per minute. How long would it take to melt?",
		"If a group of friends travel to Japan for 14 days and the cost of insurance is £26 p/p, but the insurance company gives them a 5% discount, what is the total end price?",
		"Calculate the volume of a cone with a height of 18cm and a diameter of 20cm. Remember V = 1/3Bh!",
		"What is the equation of the line passing through point (-2, 3) parallel to the line with the equation y + 4 x 7?"};
	public int[] answer = new int[]{1,2};

	public Text questionText;
	public Text headerText;
	public Text informationText;
	public Text footerText;

	public bool isActive;

	public int terminalID;
	public GameObject[] terminalPanel;



	//TODO get input from the player


	// Use this for initialization
	void Start () {
		isActive = false;
		terminalPanel = GameObject.FindGameObjectsWithTag ("terminalPanel");


	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void activatePanel()
	{
	}

	public void deativatePanel()
	{
	}

	public void clearTexts()
	{
	}

	public void setTextsOnActive()
	{
		headerText.text = "Terminal ID "+terminalID+" is running boot start-up.";
		informationText.text = "";
	}

	public void setTextsOnQuestion()
	{
		questionText.text = question [0];
		footerText.text = "ERROR: SYSTEM.OVERRIDE = true" +
			" Terminal ID "+terminalID+" attempting to connect...";
	}
}
