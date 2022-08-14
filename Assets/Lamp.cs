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
    public Sprite LampOn;
    public Sprite LampOff;
    // Start is called before the first frame update
    void Awake()
    {
        Sonoro = gameObject.GetComponent<AudioSource>();
        adminPuz = FindObjectOfType<PuzzleManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EventoMistico()
    {
        switch (adminPuz.hasLightBlob)
        {
            case true:
                if (Aparicion.activeInHierarchy == true)
                {
                    Aparicion.SetActive(false);
                    LampObject.GetComponent<Image>().sprite = LampOn;
                }
                else
                {
                    Aparicion.SetActive(true);
                    LampObject.GetComponent<Image>().sprite = LampOff;
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
