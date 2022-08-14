using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatStatue : MonoBehaviour
{
    public Sprite flipCatSprite;
    public PuzzleManager puzzleManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FlipCat()
    {
        if (puzzleManager.clockSolved)
        {
            GetComponent<Image>().sprite = flipCatSprite;
            puzzleManager.EnableCodeWheel();
        }
        
    }
}
