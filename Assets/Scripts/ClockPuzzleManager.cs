using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockPuzzleManager : MonoBehaviour
{
    public GameObject redClockwiseGrades, blackClockwiseGrades;
    public float redGradesToWin, blackGradesToWin;
    private AudioSource audioSource;
    public AudioClip[] shoot;
    private AudioClip shootClip;
    public AudioClip catSound;
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int index = Random.Range(0, shoot.Length);
            shootClip = shoot[index];
            audioSource.clip = shootClip;
            audioSource.Play();
        }

        if (redClockwiseGrades.GetComponent<ClockWise>().gradesToEnd == redGradesToWin &&
           blackClockwiseGrades.GetComponent<ClockWise>().gradesToEnd == blackGradesToWin)
        {
            isSolved = true;
            
        }
    }

    public bool isSolved = false;
    // Update is called once per frame.
    public void DebugGrades()
    {
        Debug.Log("red grades = " + redClockwiseGrades.GetComponent<ClockWise>().gradesToEnd);
        Debug.Log("Black grades = " + blackClockwiseGrades.GetComponent<ClockWise>().gradesToEnd);
    }

    public void PlayCatSound()
    {
        if (isSolved)
        {
            audioSource.clip = catSound;
            audioSource.Play();
        }
        else
        {
            int index = Random.Range(0, shoot.Length);
            shootClip = shoot[index];
            audioSource.clip = shootClip;
            audioSource.Play();
        }
    }
}
