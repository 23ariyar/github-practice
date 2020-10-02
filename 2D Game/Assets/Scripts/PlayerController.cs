using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed = 3f;
    public float jumpSpeed = 3f;
    private Transform playerTransform;
    private float movement = 0f;
    private Rigidbody2D rigidBody;
    bool isgrounded = true;


    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        playerTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
        movement = Input.GetAxis("Horizontal");
        if (movement > 0f) //Moving to the right
        {
            rigidBody.velocity = new Vector2(movement * playerSpeed, rigidBody.velocity.y);
            playerTransform.localScale = new Vector3(1, 1, 1);
        } 
        else if (movement < 0f) //Moving to the left
        {
            rigidBody.velocity = new Vector2(movement * playerSpeed, rigidBody.velocity.y);
            playerTransform.localScale = new Vector3(-1, 1, 1);
        }
        else //Velocity 0
        {
            rigidBody.velocity = new Vector2(0, rigidBody.velocity.y);
        }

        if (Input.GetButtonDown ("Jump") && isgrounded == true) //Jumping
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpSpeed);
        }
    
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        bool isShiftKeyDown = Input.GetKey(KeyCode.LeftShift);
        if (other.gameObject.tag == "Platform" && isShiftKeyDown) //Shift key
        {
            if (rigidBody.velocity.y < 2f) //Less than two, round to 0
            {
                rigidBody.velocity = new Vector2(rigidBody.velocity.x, 0);
            }
            else //More than two, divide by 3
            {
                rigidBody.velocity = new Vector2(rigidBody.velocity.x, rigidBody.velocity.y / 3);
            } 
        }
        

    }
    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Platform" || other.gameObject.tag == "Barrel") //If it's on top of a platform or a barell, it should be grounded
        {
            isgrounded = true;
        } else if (other.gameObject.tag.Contains("Sticky")) //If it encounters a sticky object
        {
            Debug.Log("Sticky");
            rigidBody.constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation; //freeze x posiiton and just keeping z rotation frozen
        }
    }
    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Platform" || other.gameObject.tag == "Barrel") //once it exits a platform or a barell, it is no longer grounded
        {
            isgrounded = false;
        }
        if (other.gameObject.tag.Contains("Sticky")) //If it leaves a sticky object
        {
            rigidBody.constraints = RigidbodyConstraints2D.FreezeRotation; //unfreeze x
        }
    }

    
}
