using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class disk : MonoBehaviour
{
    public AudioSource Ambiance;
    public Button wheel;
    public GameObject PanelFinal;
    private AudioSource endAudio;
    // Start is called before the first frame update
    void Start()
    {
        endAudio = GetComponent<AudioSource>();
    }

    public void getOut()
    {
        Debug.Log("ok");
        StartCoroutine("estrambotico");
    }
    public IEnumerator estrambotico()
    {
        //System.IO.File.WriteAllText(System.IO.Directory.GetCurrentDirectory(), "you shouldn't have done that");
        wheel.gameObject.SetActive(false);
        Ambiance.Stop();
        PanelFinal.SetActive(true);
        endAudio.Play();
        yield return new WaitForSeconds(1);
        Application.Quit();
    }
}
