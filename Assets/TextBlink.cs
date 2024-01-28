using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBlink : MonoBehaviour
{
    bool blink = false;
    public float blinkInterval = 1f;
    float timer = 0f;
    public GameObject blinkObj;

    private void Start()
    {
        blink = true;
    }
    private void Update()
    {
        if (blink)
        {
            if (timer <= 0)
            {
                blinkObj.SetActive(!blinkObj.activeSelf);
                timer = blinkInterval;
            }
            else
            {
                timer -= Time.deltaTime;
            }
        }
    }
}
