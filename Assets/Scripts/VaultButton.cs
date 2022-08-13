using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class VaultButton : MonoBehaviour
{
    public VaultManager vaultManager;

    // Start is called before the first frame update
    void Start()
    {
        vaultManager = GameObject.Find("VaultPuzzle").GetComponent<VaultManager>();
    }

    public void SelectButton()
    {
        vaultManager.AddButtonToList(this.gameObject);
        
    }
}
