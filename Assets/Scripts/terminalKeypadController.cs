using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class terminalKeypadController : MonoBehaviour {

	public Text inputText;
	public string inputNumberS;//ended with an S to indicate that it is a string
	public float playerAnswerInput;
	public float buttonPressedN;
	public int keypressCounter;

	//strings for calculator input
	public string oneS = "1";
	public string twoS = "2";
	public string threeS = "3";
	public string fourS = "4";
	public string fiveS = "5";
	public string sixS = "6";
	public string sevenS = "7";
	public string eightS = "8";
	public string nineS = "9";
	public string zeroS = "0";
	public string decimalPointS = ".";


	// Use this for initialization
	void Start () 
	{
		inputText.text = "";
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
		inputText.text = inputNumberS;
	}

	public void addNumberToInputText()
	{
		
	}

	public void clearInput()
	{
		inputText.text = "";
		playerAnswerInput = 0f;
	}

	public void oneButtonPressed()
	{
		Debug.Log (inputNumberS);
		inputNumberS = inputNumberS + oneS;
		keypressCounter++;
		updateDisplayInput ();
	}
	public void twoButtonPressed()
	{
		Debug.Log (inputNumberS);
		inputNumberS = inputNumberS + twoS;
		keypressCounter++;
		updateDisplayInput ();
	}
	public void threeButtonPressed()
	{
		Debug.Log (inputNumberS);
		inputNumberS = inputNumberS + threeS;
		keypressCounter++;
		updateDisplayInput ();
	}
	public void fourButtonPressed()
	{
		Debug.Log (inputNumberS);
		inputNumberS = inputNumberS + fourS;
		keypressCounter++;
		updateDisplayInput ();
	}
	public void fiveButtonPressed()
	{
		Debug.Log (inputNumberS);
		inputNumberS = inputNumberS + fiveS;
		keypressCounter++;
		updateDisplayInput ();
	}
	public void sixButtonPressed()
	{
		Debug.Log (inputNumberS);
		inputNumberS = inputNumberS + sixS;
		keypressCounter++;
		updateDisplayInput ();
	}
	public void sevenButtonPressed()
	{
		Debug.Log (inputNumberS);
		inputNumberS = inputNumberS + sevenS;
		keypressCounter++;
		updateDisplayInput ();
	}
	public void eightButtonPressed()
	{
		Debug.Log (inputNumberS);
		inputNumberS = inputNumberS + eightS;
		keypressCounter++;
		updateDisplayInput ();
	}
	public void nineButtonPressed()
	{
		Debug.Log (inputNumberS);
		inputNumberS = inputNumberS + nineS;
		keypressCounter++;
		updateDisplayInput ();
	}
	public void zeroButtonPressed()
	{
		Debug.Log (inputNumberS);
		inputNumberS = inputNumberS + zeroS;
		keypressCounter++;
		updateDisplayInput ();
	}
	public void decimalPointButtonPressed()
	{
		Debug.Log (inputNumberS);
		inputNumberS = inputNumberS + decimalPointS;
		keypressCounter++;
		updateDisplayInput ();
	}
}
