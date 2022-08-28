using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monoLito : MonoBehaviour
{
    private Animator animatione;
    // Start is called before the first frame update
    void Start()
    {
        animatione = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        animatione.Play("Mono");
    }
}
