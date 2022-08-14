using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBulb : MonoBehaviour
{
    public PuzzleManager puzzleManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeLightBulb()
    {
        Debug.Log("apretado lamparita");
        puzzleManager.hasLightBlob = true;
        Destroy(this.gameObject);
    }
}
