using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    public CodeWheelController codeWheel;
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
                codeWheel.downPartImages[0].enabled = true;
            }
        }

        if (GameObject.Find("ClockPuzzle").GetComponent<ClockPuzzleManager>().isSolved)
        {
            codeWheel.downPartImages[1].enabled = true;
        }
        /*
        if (GameObject.Find("PuzzleEj (2)").GetComponent<Puzzle>().isSolved)
        {
            codeWheel.downPartImages[2].enabled = true;
        }
        if (GameObject.Find("PuzzleEj (3)").GetComponent<Puzzle>().isSolved)
        {
            codeWheel.downPartImages[3].enabled = true;
        }*/
    }
}
