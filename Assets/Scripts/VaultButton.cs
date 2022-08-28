using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class VaultButton : MonoBehaviour
{
    public string btnValue;
    public VaultManager vaultManager;
    private AudioSource btnAudio;
    // Start is called before the first frame update
    void Start()
    {
        vaultManager = GameObject.Find("VaultPuzzle").GetComponent<VaultManager>();
        btnAudio = gameObject.GetComponent<AudioSource>();
    }

    public void SelectButton()
    {
        vaultManager.inputCode = vaultManager.inputCode + btnValue;
        StartCoroutine(vaultManager.CompraeButtons());
        //vaultManager.CompraeButtons();

        
        //vaultManager.AddButtonToList(this.gameObject);        
    }
}
