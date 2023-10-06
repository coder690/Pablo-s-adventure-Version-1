using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioMovement : MonoBehaviour
{
    private Animator animate;
    public float moveSpeedBase = 3.2f;
    private float moveSpeed;

    public float jumpHeight = 10.5f;

    public bool isSprinting;

    public GameObject groundCheck;

    public LayerMask groundLayer;

    // Start is called before the first frame update
    void Start()
    {
       animate = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animate.Play("Idle");

        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = moveSpeedBase * 1.5f;
            isSprinting = true;
        }
        else
        {
            moveSpeed = moveSpeedBase;
            isSprinting=false;
        }

        if (Input.GetKey(KeyCode.D))
        {
            Quaternion rotation = gameObject.transform.rotation;
            rotation.y = 0;
            gameObject.transform.rotation = rotation;

            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);

            if (isSprinting)
            {
                animate.Play("Sprint");
            }
            else {
                animate.Play("Pablo_walk");
            }
        } 

        if (Input.GetKey(KeyCode.A))
        {
            Quaternion rotation = gameObject.transform.rotation;
            rotation.y = -180;
            gameObject.transform.rotation = rotation;

            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);

            if (isSprinting)
            {
                animate.Play("Sprint");
            }
            else
            {
                animate.Play("Pablo_walk");
            }
        }

        if (IsGrounded())
        {
            if (Input.GetKey(KeyCode.Space))
            {
                transform.Translate(Vector2.up * jumpHeight * Time.deltaTime);
                animate.Play("Idle");
            }
        }
        
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.transform.position, 0.02f, groundLayer);
    }
}
