using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandMove : MonoBehaviour
{
    public float moveSpeed = 1f;
    private bool moving = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!moving) StartMoving();
            else StopMoving();
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
