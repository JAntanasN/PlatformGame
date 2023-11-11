using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockHR : MonoBehaviour
{
    public float speed = 3.0f;
    private float originalX;
    private bool moveRight = true;

    void Start()
    {
        originalX = transform.position.x;
        InvokeRepeating("ToggleMoveDirection", 3.0f, 3.0f);
    }


    void Update()
    {
        if (moveRight)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }

    void ToggleMoveDirection()
    {
        moveRight = !moveRight; // move
    }
}
