using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CellphoneController : MonoBehaviour
{
    public Sprite onImage, offImage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TurnOnCellphone()
    {
        GetComponent<Image>().sprite = onImage;
    }
}
