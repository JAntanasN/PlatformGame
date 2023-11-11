using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockUpandDown : MonoBehaviour
{

    public float speed = 2.0f;
    private float originalY;
    private bool moveUp = true;

    void Start()
    {
        originalY = transform.position.y;
        InvokeRepeating("ToggleMoveDirection", 2.0f, 2.0f);
    }

    void Update()
    {
        if (moveUp)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }

    void ToggleMoveDirection()
    {
        moveUp = !moveUp;
    }
}
