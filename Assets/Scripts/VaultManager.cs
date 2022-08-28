using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VaultManager : MonoBehaviour
{
    public GameObject parentPanel;
    public List<GameObject> currentVaultButtons = new List<GameObject>();
    public List<GameObject> correctVaultButtons = new List<GameObject>();
    public Button[] allButtons;
    public GameObject currentButton;
    public bool isSolved = false;
    public Sprite openVault, msjVault;
    public GameObject lightBlub;
    public string vaultCode;
    public string inputCode;
    public AudioClip audioWrong;
    public AudioClip audioCorrect;
    public AudioClip oof;
    public AudioClip openDoor;
    private AudioSource result;
    // Start is called before the first frame update
    void Start()
    {
        UnfreezeButtons();
        allButtons = GetComponentsInChildren<Button>();
        result = gameObject.GetComponent<AudioSource>();
        Debug.Log("Vault Panel Parent: " + parentPanel.name);
    }

    private void OnEnable()
    {
        if (isSolved == false)
        {
            UnfreezeButtons();
            inputCode = "";
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

     public void DeactivateButtons()
     {
        foreach (Button vaultBtn in allButtons)
        {
          vaultBtn.gameObject.SetActive(false);
        }     
     }

    public void FreezeButtons()
    {
        foreach (Button vaultBtn in allButtons)
        {
            vaultBtn.GetComponent<Button>().enabled = false;
        }
    }

    public void UnfreezeButtons()
    {
        foreach (Button vaultBtn in allButtons)
        {
            vaultBtn.GetComponent<Button>().enabled = true;
        }
    }

    public IEnumerator CompraeButtons()
    {
        //Debug.Log("Comparando");
        if (inputCode.Length == vaultCode.Length)
        {
            if (inputCode == vaultCode)
            {
                FreezeButtons();
                isSolved = true;
                result.clip = audioCorrect;
                result.Play();
                yield return new WaitForSeconds(audioCorrect.length);
                UnfreezeButtons();
            }
            else
            {
                FreezeButtons();
                inputCode = "";
                result.clip = audioWrong;
                result.Play();
                yield return new WaitForSeconds(3);
                UnfreezeButtons();
            }
                
        }
        //Debug.Log("Hemos presionado " + currentVaultButtons.Count + " botones.");
        //Debug.Log("Hay que presionar " + correctVaultButtons.Count + " botones.");
        //if (currentVaultButtons.Count == correctVaultButtons.Count && currentVaultButtons.Count != 0)
        //{
        //    for (int i = 0; i < correctVaultButtons.Count; i++)
        //    {
        //        if (currentVaultButtons[i] != correctVaultButtons[i])
        //        {
        //            isSolved = false;
        //        }
        //        else { isSolved = true; }
        //    }

        //}
        //else { ClearButtons(); }
    }
    public void ClearButtons()
    {
        currentVaultButtons = new List<GameObject>();
    }

   public void  TryOpenVault()
    {
        StartCoroutine(OpenVault());       
    }
    public IEnumerator OpenVault()
    {
        if (isSolved)
        {
            result.clip = openDoor;
            result.Play();
            DeactivateButtons();
            GetComponent<Image>().sprite = openVault;
            lightBlub.SetActive(true);
        }
        else
        {
            result.clip = oof;
            result.Play();
            yield return new WaitForSeconds(oof.length);
        }
            

    }


}
