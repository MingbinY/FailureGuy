using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending_Micky : Ending
{
    public GameObject mickyAnim;

    public float zoomInSize = 0.2f;
    public float zoomInSpeed = 1f;


    public override void TriggerEnding()
    {
        base.TriggerEnding();
        StartCoroutine(MickyEndingSequence());

    }

    IEnumerator MickyEndingSequence()
    {
        yield return null;
        //Switch Camera
        endingCam.gameObject.SetActive(true);
        Camera.main.gameObject.SetActive(false);
        //Zoom In
        yield return new WaitForSeconds(1f);
        for (float i = endingCam.orthographicSize; i > zoomInSize; i -= Time.deltaTime * zoomInSpeed)
        {
            endingCam.orthographicSize = i;
            yield return null;
        }
        mickyAnim.SetActive(true);
        PlayEndingSound(true);
        yield return new WaitForSeconds(endingSound.length);
        RestartGame();
    }
}
