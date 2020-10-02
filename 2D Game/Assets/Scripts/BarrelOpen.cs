using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelOpen : MonoBehaviour
{

    private Animator barrelAnimator;
    private bool isFireOneButtonDown;
    const string OPEN_ANIM = "Opened";
    public float delay = 0f;

    void Start()
    {
        barrelAnimator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //isFireOneButtonDown = Input.GetButtonDown(KeyCode.F);
        //Debug.Log(isFKeyDown.ToString());
    }

    void OnCollisionStay2D(Collision2D col)
    {
        isFireOneButtonDown = Input.GetButtonDown("Fire1");
        if (col.gameObject.tag == "Player" && isFireOneButtonDown)
        {
            Debug.Log("2");
            barrelAnimator.SetTrigger(OPEN_ANIM);
            
        }
    }
}
