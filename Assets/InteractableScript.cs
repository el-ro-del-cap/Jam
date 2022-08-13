using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableScript : MonoBehaviour
{
    public Text tecstObjeto;
    public string TextoDesc;
    // Start is called before the first frame update
    void Start()
    {
        
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
}
