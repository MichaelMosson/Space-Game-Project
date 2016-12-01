using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class terminalKeypadController : MonoBehaviour {

	public string inputNumberS;//ended with an S to indicate that it is a string
	public float playerAnswerInput;
	public float buttonPressedN;
	public int keypressCounter;

	//strings array for calculator input
    public string[] numbers = new string[] { "1", "2","3","4","5","6","7","8","9","0","." };

    private terminalController terminalcontroller;


	// Use this for initialization
	void Start () 
	{
        terminalcontroller = GetComponent<terminalController>();
		playerAnswerInput = 0f;
		keypressCounter = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (keypressCounter > 9) 
		{
			//Don't allow any more keypresses, apart from clear and enter
			Debug.Log("overflow keypresses");
		}
	
	}

	public void onEnterPressed()
	{
		//change string to float and compare answer
		
	}

	public void updateDisplayInput()
	{

	}

	public void addNumberToInputText()
	{
		
	}

	public void clearInput()
	{
		
		playerAnswerInput = 0f;
	}

	public void onClickOne()
	{
		Debug.Log (inputNumberS);
		inputNumberS = inputNumberS + numbers[0];
		keypressCounter++;
		updateDisplayInput ();
	}
	public void onClickTwo()
	{
		Debug.Log (inputNumberS);
		inputNumberS = inputNumberS + numbers[1];
		keypressCounter++;
		updateDisplayInput ();
	}
	public void onClickThree()
	{
		Debug.Log (inputNumberS);
		inputNumberS = inputNumberS + numbers[2];
		keypressCounter++;
		updateDisplayInput ();
	}
	public void onClickFive()
	{
		Debug.Log (inputNumberS);
		inputNumberS = inputNumberS + numbers[3];
		keypressCounter++;
		updateDisplayInput ();
	}
	public void onClickSix()
	{
		Debug.Log (inputNumberS);
		inputNumberS = inputNumberS + numbers[4];
		keypressCounter++;
		updateDisplayInput ();
	}
	public void onClickSeven()
	{
		Debug.Log (inputNumberS);
		inputNumberS = inputNumberS + numbers[5];
		keypressCounter++;
		updateDisplayInput ();
	}
	public void onClickEight()
	{
		Debug.Log (inputNumberS);
		inputNumberS = inputNumberS + numbers[6];
		keypressCounter++;
		updateDisplayInput ();
	}
	public void onClickNine()
	{
		Debug.Log (inputNumberS);
		inputNumberS = inputNumberS + numbers[7];
		keypressCounter++;
		updateDisplayInput ();
	}
	public void onClickTen()
	{
		Debug.Log (inputNumberS);
		inputNumberS = inputNumberS + numbers[8];
		keypressCounter++;
		updateDisplayInput ();
	}
	public void onClickZero()
	{
		Debug.Log (inputNumberS);
		inputNumberS = inputNumberS + numbers[9];
		keypressCounter++;
		updateDisplayInput ();
	}
	public void onClickDecimalPoint()
	{
		Debug.Log (inputNumberS);
		inputNumberS = inputNumberS + numbers[10];
		keypressCounter++;
		updateDisplayInput ();
	}
}
