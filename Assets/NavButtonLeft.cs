using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NavButtonLeft : MonoBehaviour
{
    public Button OppositeButton;
    public GameObject parentPanel;
    public GameObject[] Paneloides;
    public GameObject currentPanel;
    public GameObject nextPanelLeft;
    public GameObject nextPanelRight;
    private string currentPanelName;
    public void ChangeScreenLeft()
    {
        switch (currentPanelName)
        {
            case "Screen1":
                //nextPanel = GameObject.Find("Screen4");
                //nextPanel.SetActive(true);
                parentPanel.gameObject.transform.Find("Screen4").gameObject.SetActive(true);
                currentPanel.SetActive(false);
                currentPanelName = nextPanelLeft.name;
                currentPanel = Paneloides[3];
                nextPanelLeft = Paneloides[2];
                nextPanelRight = Paneloides[0];
                UpdateOppositeButton(3, 0, 2);
                break;
            case "Screen2":
                //nextPanel = GameObject.Find("Screen1");
                //nextPanel.SetActive(true);
                parentPanel.gameObject.transform.Find("Screen1").gameObject.SetActive(true);
                currentPanel.SetActive(false);
                currentPanelName = nextPanelLeft.name;
                currentPanel = Paneloides[0];
                nextPanelLeft = Paneloides[3];
                nextPanelRight = Paneloides[1];
                UpdateOppositeButton(0, 1, 3);
                break;
            case "Screen3":
                //nextPanel = GameObject.Find("Screen2");
                //nextPanel.SetActive(true);
                parentPanel.gameObject.transform.Find("Screen2").gameObject.SetActive(true);
                currentPanel.SetActive(false);
                currentPanelName = nextPanelLeft.name;
                currentPanel = Paneloides[1];
                nextPanelLeft = Paneloides[0];
                nextPanelRight = Paneloides[2];
                UpdateOppositeButton(1, 2, 0);
                break;
            case "Screen4":
                //nextPanel = GameObject.Find("Screen3");
                //nextPanel.SetActive(true);
                parentPanel.gameObject.transform.Find("Screen3").gameObject.SetActive(true);
                currentPanel.SetActive(false);
                currentPanelName = nextPanelLeft.name;
                currentPanel = Paneloides[2];
                nextPanelLeft = Paneloides[1];
                nextPanelRight = Paneloides[3];
                UpdateOppositeButton(2, 3, 1);
                break;
                
        }
    }

    public void ChangeScreenRight()
    {
        switch (currentPanelName)
        {
            case "Screen1":
                //nextPanel = GameObject.Find("Screen4");
                //nextPanel.SetActive(true);
                parentPanel.gameObject.transform.Find("Screen2").gameObject.SetActive(true);
                currentPanel.SetActive(false);
                currentPanelName = nextPanelRight.name;
                currentPanel = Paneloides[1];
                nextPanelRight = Paneloides[2];
                nextPanelLeft = Paneloides[0];
                UpdateOppositeButton(1, 2, 0);
                break;
            case "Screen2":
                //nextPanel = GameObject.Find("Screen1");
                //nextPanel.SetActive(true);
                parentPanel.gameObject.transform.Find("Screen3").gameObject.SetActive(true);
                currentPanel.SetActive(false);
                currentPanelName = nextPanelRight.name;
                currentPanel = Paneloides[2];
                nextPanelRight = Paneloides[3];
                nextPanelLeft = Paneloides[1];
                UpdateOppositeButton(2, 3, 1);
                break;
            case "Screen3":
                //nextPanel = GameObject.Find("Screen2");
                //nextPanel.SetActive(true);
                parentPanel.gameObject.transform.Find("Screen4").gameObject.SetActive(true);
                currentPanel.SetActive(false);
                currentPanelName = nextPanelRight.name;
                currentPanel = Paneloides[3];
                nextPanelRight = Paneloides[0];
                nextPanelLeft = Paneloides[2];
                UpdateOppositeButton(3, 0, 2);
                break;
            case "Screen4":
                //nextPanel = GameObject.Find("Screen3");
                //nextPanel.SetActive(true);
                parentPanel.gameObject.transform.Find("Screen1").gameObject.SetActive(true);
                currentPanel.SetActive(false);
                currentPanelName = nextPanelRight.name;
                currentPanel = Paneloides[0];
                nextPanelRight = Paneloides[1];
                nextPanelLeft = Paneloides[3];
                UpdateOppositeButton(0, 1, 3);

                break;

        }
    }
    public void UpdateOppositeButton(int updateCurrentPanel, int updateNextPanelRight, int updateNextPanelLeft)
    {
        OppositeButton.GetComponent<NavButtonLeft>().currentPanel = Paneloides[updateCurrentPanel];
        OppositeButton.GetComponent<NavButtonLeft>().nextPanelLeft = Paneloides[updateNextPanelLeft];
        OppositeButton.GetComponent<NavButtonLeft>().nextPanelRight = Paneloides[updateNextPanelRight];
        OppositeButton.GetComponent<NavButtonLeft>().currentPanelName = gameObject.GetComponent<NavButtonLeft>().currentPanelName;
        
    }
    // Start is called before the first frame update
    void Start()
    {
        currentPanelName = Paneloides[0].name;
        currentPanel = Paneloides[0];
        nextPanelLeft = Paneloides[3];
        nextPanelRight = Paneloides[1];
        Debug.Log("Current Panel: " + currentPanel + ", Name: " + currentPanelName);
        Debug.Log("Next Panel Left: " + nextPanelLeft);
        Debug.Log("Next Panel Right: " + nextPanelRight);
    }
}
