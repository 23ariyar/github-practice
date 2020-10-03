using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clicks : MonoBehaviour
{


    private int clicks = 0;
    public Text clicksText;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        clicksText.text = "CLICKS : " + clicks;
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            clicks++;
        }
    }
}
