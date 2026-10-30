using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class BasicMovement : MonoBehaviour
{
    public float speed = 10.0f;
    public float jumpspeed = 300.0f;
    public Rigidbody rb;
    public GameObject hb;
    float xforce = 0.0f;
    float yforce = 0.0f;
    float zforce = 0.0f;
    bool isGrounded = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current.wKey.isPressed)
        {
            zforce = speed;
        }

        if(Keyboard.current.sKey.isPressed)
        {
            zforce = -speed;
        }

        if (Keyboard.current.aKey.isPressed)
        {
            xforce = -speed;
        }

        if (Keyboard.current.dKey.isPressed)
        {
            xforce = speed;
        }

        if (Keyboard.current.spaceKey.isPressed && isGrounded == true)
        {
            yforce = jumpspeed;
        }
    }

    void FixedUpdate()
    {
        rb.AddForce(new Vector3 (xforce, yforce, zforce), ForceMode.Force);
        if (yforce > 0.0f)
        {
            isGrounded = false;
        }
        xforce = 0.0f;
        yforce = 0.0f;
        zforce = 0.0f;
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }
}
