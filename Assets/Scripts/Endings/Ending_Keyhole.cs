using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending_Keyhole : Ending
{
    public GameObject keyholeAnim;
    public override void TriggerEnding()
    {
        base.TriggerEnding();
        StartCoroutine(KeyholeEnding());
    }

    IEnumerator KeyholeEnding()
    {
        yield return null;
        //Switch Cam
        endingCam.gameObject.SetActive(true);
        Camera.main.gameObject.SetActive(false);
        yield return new WaitForSeconds(1f);
        keyholeAnim.SetActive(true);
    }
}
