using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lamp : MonoBehaviour
{
    public Text WarningText;
    private PuzzleManager adminPuz;
    public GameObject Aparicion;
    private AudioSource Sonoro;
    public GameObject LampObject;
    public GameObject LampZoom;
    public Sprite LampOn;
    public Sprite LampOff;
    // Start is called before the first frame update
    void Awake()
    {
        Sonoro = gameObject.GetComponent<AudioSource>();
        adminPuz = FindObjectOfType<PuzzleManager>();
    }

    public void EventoMistico()
    {
        switch (adminPuz.hasLightBlob)
        {
            case true:
                if (Aparicion.activeInHierarchy == true)
                {
                    Aparicion.SetActive(false);
                    LampObject.GetComponent<Image>().sprite = LampOff;
                    LampZoom.GetComponent<Image>().sprite = LampOff;
                }
                else
                {
                    Aparicion.SetActive(true);
                    LampObject.GetComponent<Image>().sprite = LampOn;
                    LampZoom.GetComponent<Image>().sprite = LampOn;
                }
                Sonoro.Play();
                break;
            case false:
                WarningText.text = "I need a light bulb.";
                Sonoro.Play();
                break;
        }
    }
}
