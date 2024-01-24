using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending_Frog : Ending
{
    public GameObject frogAnim;
    public override void TriggerEnding()
    {
        base.TriggerEnding();
        StartCoroutine(FrogEnding());
    }

    IEnumerator FrogEnding()
    {
        yield return null;
        //Switch Cam
        endingCam.gameObject.SetActive(true);
        Camera.main.gameObject.SetActive(false);
        yield return new WaitForSeconds(1f);
        frogAnim.SetActive(true);

    }
}
