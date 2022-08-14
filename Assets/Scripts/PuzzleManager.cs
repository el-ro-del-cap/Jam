using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    public CodeWheelController codeWheel;
    public GameObject wheelBtn;
    public GameObject endBtn;
    public bool hasLightBlob = false, hasDecoder = false, clockSolved = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Delete))
        {
            EnableCodeWheel();
            gameObject.GetComponent<AudioSource>().Play();
        }
    }

    public void EnableCodeWheel()
    {
        hasDecoder = true; 
        wheelBtn.SetActive(true);
        endBtn.SetActive(true);
    }


}
