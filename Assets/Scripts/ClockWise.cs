using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockWise : MonoBehaviour
{
   // ClockPuzzleManager clockManager;
    public float gradesToRotate;
    public float gradesToEnd = 0;
    public RectTransform myGrades;

    private void Start()
    {
        myGrades = this.gameObject.GetComponent<RectTransform>();
    }
    public void RotateClockwisel()
    {
        gradesToEnd += gradesToRotate;
        myGrades.Rotate(new Vector3(0, 0, -gradesToRotate));       
        CorrectGrades();
        GameObject.Find("ClockPuzzle").GetComponent<ClockPuzzleManager>().DebugGrades();
    }

    void CorrectGrades()
    {
        if(gradesToEnd >= 360)
        {
            gradesToEnd = 0;
        }      
    }
}
