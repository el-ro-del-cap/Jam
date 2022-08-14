using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lamp : MonoBehaviour
{
    public GameObject Aparicion;
    private AudioSource Sonoro;
    // Start is called before the first frame update
    void Awake()
    {
        Sonoro = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EventoMistico()
    {
        if (Aparicion.activeInHierarchy == true)
            Aparicion.SetActive(false);
        else
            Aparicion.SetActive(true);
        Sonoro.Play();
    }
}
