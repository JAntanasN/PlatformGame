using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockHL : MonoBehaviour
{
    public float speed = 3.0f;
    private float originalX;
    private bool moveLeft = true;

    void Start()
    {
        originalX = transform.position.x;
        InvokeRepeating("ToggleMoveDirection", 3.0f, 3.0f);
    }


    void Update()
    {
        if (moveLeft)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }

    void ToggleMoveDirection()
    {
        moveLeft = !moveLeft; // move
    }
}
