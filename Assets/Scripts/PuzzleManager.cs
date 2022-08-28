using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    public CodeWheelController codeWheel;
    public GameObject wheelBtn;
    public GameObject endBtn;
    public bool hasLightBlob = false, hasDecoder = false, clockSolved = false;


    // Update is called once per frame
    void Update()
    {   
        //saul goodman
        //if (Input.GetKey(KeyCode.Delete))
        //{
        //    EnableCodeWheel();
        //    gameObject.GetComponent<AudioSource>().Play();
        //}
    }

    public void EnableCodeWheel()
    {
        hasDecoder = true; 
        wheelBtn.SetActive(true);
        endBtn.SetActive(true);
    }


}
