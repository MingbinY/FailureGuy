using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending_Button : Ending
{
    public GameObject buttonAnim;
    public override void TriggerEnding()
    {
        base.TriggerEnding();
        StartCoroutine(ButtonEnding());
    }

    IEnumerator ButtonEnding()
    {
        yield return null;
        //Switch Cam
        endingCam.gameObject.SetActive(true);
        Camera.main.gameObject.SetActive(false);
        yield return new WaitForSeconds(1f);
        buttonAnim.SetActive(true);

    }
}
