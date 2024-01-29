using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending_Frog : Ending
{
    public GameObject frogAnim;
    public GameObject character;
    public float frogFadeInTime = 1f;
    public float characterFadeOutTime = 1f;
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
        SpriteManager sm = FindObjectOfType<SpriteManager>();
        if (sm != null)
        {
            sm.FadeIn(frogAnim.GetComponent<SpriteRenderer>(), frogFadeInTime);
            sm.FadeOut(character.GetComponent<SpriteRenderer>(), characterFadeOutTime);
        }
        yield return new WaitForSeconds(frogFadeInTime);
        PlayEndingSound();
        frogAnim.GetComponent<Animator>().SetTrigger("FrogJump");
        yield return new WaitForSeconds(5);
        RestartGame();
    }
}
