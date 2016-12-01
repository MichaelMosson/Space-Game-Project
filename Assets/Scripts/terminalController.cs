using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class terminalController : MonoBehaviour {

	public string[] question = new string[]{"blank","If an ice cube has a length width and depth of 6cm each and melts at 8 cubic cm per minute. How long would it take to melt?",
		"If a group of 5 friends travel to Japan for 14 days and the cost of insurance is £26 p/p, but the insurance company gives them a 5% discount, what is the total end price?",
		"Calculate the volume of a cone with a height of 18cm and a diameter of 20cm. Remember V = 1/3Bh!",
		"What is the equation of the line passing through point (-2, 3) parallel to the line with the equation y + 4 x 7?"};

    //public float[] answer = new float[] { 27f, 123.5f, 120f, 100f, 1337f };
    public string[] answerVal = new string[] { "blank", "27", "123.5", "120","100" };

    public Text questionText;
	public Text headerText;
	public Text informationText;
	public Text footerText;
	public Text alertText;

	public bool isActive;

    public float playerGuessN;


	public int terminalID = 1;
	public int number;
	public GameObject terminalPanel;
    public GameObject DoorBlock;
    public GameObject InputField;

	private Desk desk;

	//TODO get input from the player


	// Use this for initialization
	void Start () {
		//terminalPanel.SetActive (false);
		desk = GetComponent<Desk> ();
		isActive = false;
        number = 1;

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (terminalPanel.gameObject.activeInHierarchy == true)
            {
                deativatePanel();
            }

        }

    }

	public void startPanel()
	{
       
        //calculate what question is shown
        Debug.Log("questionN = "+number);
        Debug.Log("question = "+question[number]);
        Debug.Log("answer = " + answerVal[number]);
        //set terminal panel gameObject as active
        terminalPanel.SetActive(true);
		//Set the texts to mimic a PC booting up
		setTextsOnActive ();
	}

	public void deativatePanel()
	{
        Debug.Log("Deactivating terminalPanel");
		clearAllTexts ();
        InputField.SetActive(false);
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
        InputField.SetActive(true);
        Debug.Log("Answer = " + answerVal[number]);
    }

    //checks the player's input
    public void checkAnswer(string guess)
    {

        footerText.text = "Checking input please wait...";

        playerGuessN = float.Parse(guess);
        Debug.Log("player endered+" + guess);

        if (guess == answerVal[number])
        {
            answerCorrect();
        }
        else if (guess != answerVal[number])
        {
            answerIncorrect();
        }
        else
        {
            footerText.text = "system corrupt, please restart terminal";
        }

    }
    //runs if player's answer is correct
    public void answerCorrect()
    {
        headerText.text ="SYSTEM.OVERRIDE Sucessful, sequence has been verified";
        DoorBlock.SetActive(false);
        informationText.text = "Door has been opened";
        questionText.text = "";
        footerText.text = "access confirmed!";
        number++;
    }

    //runs if player's answer is incorrect
    public void answerIncorrect()
    {
        headerText.text = "Sequence is corrupted.";
        footerText.text = "System Detected file: C://Hax.EXE which tried to access SYSTEM.OVERRIDE without Admin Permissions";
    }

	public void setTextsOnQuestion()
	{
		questionText.text = question [number];
		informationText.text = "";
		footerText.text = "ERROR: SYSTEM.OVERRIDE = true;" +
			" Terminal ID "+terminalID+" attempting to connect...";
		StopCoroutine ("sequence");
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
