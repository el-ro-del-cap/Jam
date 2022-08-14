using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeWheelController : MonoBehaviour
{
    public Image topPart;
    //public List<Image> downPartImages = new List<Image>();
    public float gradesToRotate = 13.8f;

    private void Start()
    {
        //Lo ponemos en la primer escena y lo dejamos ahí o lo ponemos en cada escena.
        //DontDestroyOnLoad(this);?
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
