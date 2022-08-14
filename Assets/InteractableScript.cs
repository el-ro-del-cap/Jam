using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableScript : MonoBehaviour
{
    private Button[] botones;
    private GameObject parentPanel;
    public Text tecstObjeto;
    public string TextoDesc;
    public NavButtonLeft[] BotonesNav;
    // Start is called before the first frame update
    void Awake()
    {
        BotonesNav = FindObjectsOfType<NavButtonLeft>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TextChange()
    {
        tecstObjeto.text = TextoDesc;
    }
    public void TextErase()
    {
        tecstObjeto.text = "";
    }

    public void OpenSubPanel(GameObject Panel)
    {
        Panel.SetActive(true);
        for (int i = 0; i < BotonesNav.Length; i++)
        {
            BotonesNav[i].gameObject.SetActive(false);
        }
    }
    public void CloseThisPanel(GameObject Panel)
    {
        for (int i = 0; i < BotonesNav.Length; i++)
        {
            BotonesNav[i].gameObject.SetActive(true);
        }
        Panel.SetActive(false);
    }
}
