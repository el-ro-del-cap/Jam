using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeWheel : MonoBehaviour
{
    public Image topPart, downPart;
    public float gradesToRotate = 13.8f;

    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            topPart.GetComponent<RectTransform>().Rotate(
                new Vector3(0, 0, 1 * gradesToRotate * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.D))
        {
            topPart.GetComponent<RectTransform>().Rotate(
                new Vector3(0, 0, -1 * gradesToRotate * Time.deltaTime));
        }
    }
}
