using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] private float steerSpeed = 300.0f;
    [SerializeField] private float moveSpeed = 20.0f;
    [SerializeField] private float slowSpeed = 15.0f;
    [SerializeField] private float boostSpeed = 30.0f;
    [SerializeField] private float destroyDelay = 0.3f;

    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float speedAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, speedAmount, 0);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        moveSpeed = slowSpeed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boost")
        {
            moveSpeed = boostSpeed;
        }
    }
}
