using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatStatue : MonoBehaviour
{
    public Sprite flipCatSprite;
    public PuzzleManager puzzleManager;

    public void FlipCat()
    {
        if (puzzleManager.clockSolved)
        {
            GetComponent<Image>().sprite = flipCatSprite;
            puzzleManager.EnableCodeWheel();
        }
        
    }
}
