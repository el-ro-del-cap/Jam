using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    public CodeWheelController codeWheel;
    public bool hasLightBlob = false, hasDecoder = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PuzzleSolved();
    }

    public void PuzzleSolved()
    {
        if (GameObject.Find("VaultPuzzle")) 
        {
            if (GameObject.Find("VaultPuzzle").GetComponent<VaultManager>().isSolved)
            {
                //codeWheel.downPartImages[0].enabled = true;
            }
        }
        if (GameObject.Find("ClockPuzzle"))
        {
            if (GameObject.Find("ClockPuzzle").GetComponent<ClockPuzzleManager>().isSolved)
            {
                //codeWheel.downPartImages[1].enabled = true;
            }
        }
        

    }
}
