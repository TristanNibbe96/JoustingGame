using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Targetcontroller : MonoBehaviour
{
    private Image targetImage;
    // Start is called before the first frame update
    void Start()
    {
        targetImage = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void PointerEntered()
    {
        targetImage.color = Color.green;
    }


    public void PointerExited()
    {
        targetImage.color = Color.red;
    }
}
