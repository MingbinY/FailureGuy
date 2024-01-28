using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Ending_Hair : Ending
{
    public GameObject hairAnim;
    public GameObject handObj;
    public override void TriggerEnding()
    {
        base.TriggerEnding();
        StartCoroutine(HairEnding());
    }

    IEnumerator HairEnding()
    {
        yield return null;
        endingCam.gameObject.SetActive(true);
        Camera.main.gameObject.SetActive(false);
        yield return new WaitForSeconds(1f);
        hairAnim.SetActive(true);
        hairAnim.transform.localRotation = handObj.transform.localRotation;
        hairAnim.transform.localPosition = handObj.transform.localPosition;
        handObj.SetActive(false);
        yield return new WaitForSeconds(5);
        RestartGame();
    }
}
