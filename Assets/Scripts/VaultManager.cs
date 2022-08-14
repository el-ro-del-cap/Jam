using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VaultManager : MonoBehaviour
{
    public List<GameObject> currentVaultButtons = new List<GameObject>();
    public List<GameObject> correctVaultButtons = new List<GameObject>();
    public GameObject currentButton;
    public bool isSolved = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddButtonToList(GameObject button)
    {
        currentButton = button;
        if(currentButton!= null)
        {
            currentVaultButtons.Add(currentButton);
            Debug.Log("Se agrego el boton " + currentButton.gameObject.name);
        }
        if(currentVaultButtons.Count >= correctVaultButtons.Count)
        {
            for(int i = 0; i <= correctVaultButtons.Count; i++)
            {
                if(currentVaultButtons[i] != correctVaultButtons[i])
                {
                    currentVaultButtons = new List<GameObject>();
                }
                else { isSolved = true; }                
            }
            if (isSolved)
            {
                gameObject.GetComponentsInChildren<Button>();
                //gameObject.SetActive(false);
            }
        }
    }
   /* public void DisableButtons()
    {
        List<Button> buttons = new List<Button>();
        foreach(Button button in buttons)
        {
            button = GetComponentsInChildren
        }
        
    }*/
}
