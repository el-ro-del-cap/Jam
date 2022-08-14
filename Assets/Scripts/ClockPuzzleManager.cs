using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockPuzzleManager : MonoBehaviour
{
    public GameObject redClockwiseGrades, blackClockwiseGrades;
    public float redGradesToWin, blackGradesToWin;


        
    public bool isSolved = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (redClockwiseGrades.GetComponent<ClockWise>().gradesToEnd == redGradesToWin &&
            blackClockwiseGrades.GetComponent<ClockWise>().gradesToEnd == blackGradesToWin)
        {
            isSolved = true;
        }             
    }
    public void DebugGrades()
    {
        Debug.Log("red grades = " + redClockwiseGrades.GetComponent<ClockWise>().gradesToEnd);
        Debug.Log("Black grades = " + blackClockwiseGrades.GetComponent<ClockWise>().gradesToEnd);
    }
}
