using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeysSetup : MonoBehaviour
{
    public Button noteA;
    public Button noteB;
    public Button noteC;
    public Button noteD;
    public Button noteE;
    public Button noteF;
    public Button noteG;
    public Button noteAS;
    public Button noteCS;
    public Button noteDS;
    public Button noteFS;

    bool keyAHasBeenPressed = false, keyBHasBeenPressed = false;

    void Start()
    {
        noteA.onClick.AddListener(() => KeySequenceDetector("a"));
        noteB.onClick.AddListener(() => KeySequenceDetector("b"));
        noteC.onClick.AddListener(() => KeySequenceDetector("c"));
        noteD.onClick.AddListener(() => KeySequenceDetector("d"));
        noteE.onClick.AddListener(() => KeySequenceDetector("e"));
        noteF.onClick.AddListener(() => KeySequenceDetector("f"));
        noteG.onClick.AddListener(() => KeySequenceDetector("g"));
        noteAS.onClick.AddListener(() => KeySequenceDetector("as"));
        noteCS.onClick.AddListener(() => KeySequenceDetector("cs"));
        noteDS.onClick.AddListener(() => KeySequenceDetector("ds"));
        noteFS.onClick.AddListener(() => KeySequenceDetector("fs"));
    }

    private void KeySequenceDetector(string key)
    {

        if (key == "a" || keyAHasBeenPressed)
        {
            if (key == "a")
            {
                keyAHasBeenPressed = true;
                return;
            }
            else
            {
                if (key == "b" || keyBHasBeenPressed)
                {
                    if (key == "b")
                    {
                        keyBHasBeenPressed = true;
                        return;
                    }
                    else
                    {
                        if (key == "c")
                        {
                            Debug.Log("Done!");
                            
                        }
                    }
                }
            }
        }
        keyAHasBeenPressed = false;
        keyBHasBeenPressed = false;
    }
}
