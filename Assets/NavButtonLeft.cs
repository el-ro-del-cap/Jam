using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NavButtonLeft : MonoBehaviour
{
    public GameObject parentPanel;
    public GameObject[] Paneloides;
    private GameObject currentPanel;
    private GameObject nextPanel;
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
                currentPanelName = nextPanel.name;
                currentPanel = Paneloides[3];
                nextPanel = Paneloides[2];
                break;
            case "Screen2":
                //nextPanel = GameObject.Find("Screen1");
                //nextPanel.SetActive(true);
                parentPanel.gameObject.transform.Find("Screen1").gameObject.SetActive(true);
                currentPanel.SetActive(false);
                currentPanelName = nextPanel.name;
                currentPanel = Paneloides[0];
                nextPanel = Paneloides[3];
                break;
            case "Screen3":
                //nextPanel = GameObject.Find("Screen2");
                //nextPanel.SetActive(true);
                parentPanel.gameObject.transform.Find("Screen2").gameObject.SetActive(true);
                currentPanel.SetActive(false);
                currentPanelName = nextPanel.name;
                currentPanel = Paneloides[1];
                nextPanel = Paneloides[0];
                break;
            case "Screen4":
                //nextPanel = GameObject.Find("Screen3");
                //nextPanel.SetActive(true);
                parentPanel.gameObject.transform.Find("Screen3").gameObject.SetActive(true);
                currentPanel.SetActive(false);
                currentPanelName = nextPanel.name;
                currentPanel = Paneloides[2];
                nextPanel = Paneloides[1];

                break;
                
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        currentPanelName = Paneloides[0].name;
        currentPanel = Paneloides[0];
        nextPanel = Paneloides[3];
        Debug.Log("Current Panel: " + currentPanel + ", Name: " + currentPanelName);
        Debug.Log("Next Panel Left: " + nextPanel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
