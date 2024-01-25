using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending_Other : Ending
{
    public GameObject otherAnim;
    public override void TriggerEnding()
    {
        base.TriggerEnding();
        StartCoroutine(OtherEnding());
    }

    IEnumerator OtherEnding()
    {
        yield return null;
        //Switch Cam
        endingCam.gameObject.SetActive(true);
        Camera.main.gameObject.SetActive(false);
        yield return new WaitForSeconds(1f);
        otherAnim.SetActive(true);

    }
}
