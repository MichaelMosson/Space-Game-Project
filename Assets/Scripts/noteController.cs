using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class noteController : MonoBehaviour {

    public Text noteHeaderText;
    public Text noteContentsText;
    public Text alertText;
    public GameObject notePanel;

    private UIController uiController;

    public int noteID;


	// Use this for initialization
	void Start ()
    {
        uiController = GetComponent<UIController>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnMouseEnter()
    {
        Debug.Log("Enter");
        alertText.text = "Click to read";
    }

    public void OnMouseExit()
    {
        Debug.Log("Exit");
        alertText.text = "";
        notePanel.SetActive(false);
    }

    public void OnMouseUp()
    {
        OpenNote();
    }

    public void OpenNote()
    {
        notePanel.SetActive(true);
        setTextsOnActive();
    }

    public void setTextsOnActive()
    {
        noteHeaderText.text = "Captain's Log: Earth Date: 12/7/2573";
        noteContentsText.text = "We have failed our mission. The ship has been crippled in a hostile alien attack. Exact alien spiecies is yet to be confirmed. We have lost all control of the ship, and it is drifting towards the Sirus - the star as the centre of this solar system. We are are going to ditch the ship and let it be destroyed so that the aliens can not recover our technologies.";
    
    }

    public void clearNoteTexts()
    {
        noteHeaderText.text = "";
        noteContentsText.text = "";
    }

    public void CloseNote()
    {
        clearNoteTexts();
        notePanel.SetActive(false);
    }
}
