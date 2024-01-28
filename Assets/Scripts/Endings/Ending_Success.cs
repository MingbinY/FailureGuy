using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending_Success : Ending
{
    public GameObject successAnim;
    public override void TriggerEnding()
    {
        base.TriggerEnding();
        StartCoroutine(SuccessEnding());
    }

    IEnumerator SuccessEnding()
    {
        yield return null;
        //Switch Cam
        yield return new WaitForSeconds(3);
        RestartGame();
    }
}
