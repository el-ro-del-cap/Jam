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
    public Sprite openVault;
    public GameObject lightBlub;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isSolved)
        {
            OpenVault();
        }
    }

    public void AddButtonToList(GameObject button)
    {
        currentButton = button;
        if(currentButton!= null)
        {
            currentVaultButtons.Add(currentButton);
            Debug.Log("Se agrego el boton " + currentButton.gameObject.name);
        }       
    }

     public void DisableButtons()
     {
        Button[] vaultButtons = GetComponentsInChildren<Button>();
        foreach (Button vaultButton in vaultButtons)
        {
          vaultButton.gameObject.SetActive(false);
        }     
     }

    public void CompraeButtons()
    {
        Debug.Log("Hemos presionado " + currentVaultButtons.Count + " botones.");
        Debug.Log("Hay que precionar " + correctVaultButtons.Count + " botones.");
        if (currentVaultButtons.Count == correctVaultButtons.Count && currentVaultButtons.Count != 0)
        {
            for (int i = 0; i <= currentVaultButtons.Count && i <= correctVaultButtons.Count; i++)
            {
                if (currentVaultButtons[i] != correctVaultButtons[i])
                {
                    isSolved = false;
                }
                else { isSolved = true; }
            }
        }
        else { ClearButtons(); }
    }
    public void ClearButtons()
    {
        currentVaultButtons = new List<GameObject>();
    }

   public void  TryOpenVault()
    {
        CompraeButtons();
    }
    public void OpenVault()
    {
        DisableButtons();
        GetComponent<Image>().sprite = openVault;
        lightBlub.SetActive(true);
    }

    public void TakeLightBulb()
    {

        Destroy(lightBlub);
        GameObject.Find("PuzzleManager").GetComponent<PuzzleManager>().hasLightBlob = true;
    }
}
