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
    
    }
}
