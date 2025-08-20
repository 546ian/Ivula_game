using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{
    
    private Rigidbody rb;
    private int isWalkingHash;
    public Animator playerAnim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
    }

    // Update is called once per frame
    void Update()
    {
        bool isWalking = playerAnim.GetBool(isWalkingHash);
        bool isForwardPressed = Input.GetKey(KeyCode.W);

        if (isForwardPressed && !isWalking)
        {
            rb.AddForce(Vector3.right * 1f, ForceMode.Impulse);
            playerAnim.SetBool(isWalkingHash, true);
        }

        if (!isForwardPressed && isWalking)
        {
            playerAnim.SetBool(isWalkingHash, false);
            rb.linearVelocity = Vector3.zero; // Stop the player when not walking
        }
    }
}
