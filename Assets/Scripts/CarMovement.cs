using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CarMovement : MonoBehaviour
{
    public float speed = 10f;

    private Rigidbody carRb;


    void Start()
    {
        carRb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        carRb.transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
