using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBehavior : MonoBehaviour
{
    [SerializeField] private float jumpForce = 10;
    [SerializeField] private float groundedDistance = 1;
    [SerializeField] private LayerMask groundedMask;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
    }

    private void Jump()
    {
        Rigidbody2D rb2D = GetComponent<Rigidbody2D>();

        if (IsGrounded())
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb2D.velocity = jumpForce * Vector2.up;
            }
        }
    }

    bool IsGrounded()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, groundedDistance, groundedMask);
        Debug.DrawRay(transform.position, Vector2.down * groundedDistance, Color.red);
       
        if (hit.collider == null)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
