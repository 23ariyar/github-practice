using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateClockwise : MonoBehaviour
{
    private Transform buttonTransform;




    public void Rotate()
    {
        buttonTransform = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.transform;
        buttonTransform.Rotate(0.0f, 0.0f, 90.0f, Space.World);

    }

}
