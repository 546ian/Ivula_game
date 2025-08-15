using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{
    
    private Rigidbody rb;
    public Animator playerAnim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(Vector3.right * 1f, ForceMode.Impulse);
            playerAnim.SetTrigger("walk");
        }
        
        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.AddForce(Vector3.left * 1f, ForceMode.Impulse);
            playerAnim.SetTrigger("walk");
        }
    }
}
