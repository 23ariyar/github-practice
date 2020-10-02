using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public Transform playerTransform;
    public float cameraY;
    public float cameraZ;
    private Transform cameraTransform;
    // Start is called before the first frame update
    void Start()
    {
        cameraTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (playerTransform.position.x > -4f && playerTransform.position.x < 5f)
        {
            cameraTransform.position = new Vector3(playerTransform.position.x + 4.48f, cameraY, cameraZ);
        }
        
    }
}
