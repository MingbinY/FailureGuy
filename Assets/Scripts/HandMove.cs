using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandMove : MonoBehaviour
{
    public float moveSpeed = 1f;
    private bool moving = false;
    private bool moved = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            moved = true;
            if (!moving) StartMoving();
        }
        if (moving)
        {
            transform.Translate(transform.right * Time.deltaTime*moveSpeed);
        }
    }

    public void StartMoving()
    {
        GetComponent<HandRotate>().StopRotate();
        moving = true;
    }

    public void StopMoving()
    {
        moving = false;
    }
}
