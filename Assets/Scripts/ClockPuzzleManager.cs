using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockPuzzleManager : MonoBehaviour
{
    public PuzzleManager puzzleManager;
    public RectTransform redClockwiseGrades, blackClockwiseGrades;
    public float redGradesToWin, blackGradesToWin;
    private AudioSource audioSource;
    public AudioClip[] shoot;
    public AudioClip catSound;
    public bool isSolved = false;
    
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }
    // Update is called once per frame.
   /* public void DebugGrades()
    {
        Debug.Log("red grades = " + redClockwiseGrades.GetComponent<ClockWise>().gradesToEnd);
        Debug.Log("Black grades = " + blackClockwiseGrades.GetComponent<ClockWise>().gradesToEnd);
    }*/

    public void PlayCatSound()
    {
            audioSource.clip = catSound;
            audioSource.Play();   
    }

    public void ClockCheck()
    {
        if (isSolved == false){
            int redRound = Mathf.FloorToInt(redClockwiseGrades.eulerAngles.z); //*100)/10)*10;
            int blackRound = Mathf.FloorToInt(blackClockwiseGrades.eulerAngles.z); //*100)/10)*10;
            if (redRound == redGradesToWin && blackRound == blackGradesToWin)
            {

                PlayCatSound();
                isSolved = true;
                puzzleManager.clockSolved = true;
            }
            else
            {
                int index = Random.Range(0, shoot.Length);
                audioSource.clip = shoot[index];
                audioSource.Play();
            }
        }
        else
        {
            int index = Random.Range(0, shoot.Length);
            audioSource.clip = shoot[index];
            audioSource.Play();
        }
    }
}
