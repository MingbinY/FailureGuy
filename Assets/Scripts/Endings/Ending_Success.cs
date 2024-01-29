using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending_Success : Ending
{
    public GameObject successAnim;
    public GameObject hand;
    public float moveSpeed = 1f;
    public float destinationX = 1;

    private void Awake()
    {
        hand = FindObjectOfType<HandMove>().gameObject;
    }
    public override void TriggerEnding()
    {
        base.TriggerEnding();
        StartCoroutine(SuccessEnding());
    }

    IEnumerator SuccessEnding()
    {
        yield return null;
        //Switch Cam and Sprite
        Camera.main.gameObject.SetActive(false);
        endingCam.gameObject.SetActive(true);
        hand.SetActive(false);
        successAnim.SetActive(true);
        yield return new WaitForSeconds(1);

        while (successAnim.transform.localPosition.x > destinationX)
        {
            Vector3 newPos = successAnim.transform.localPosition;
            newPos.x -= Time.deltaTime * moveSpeed;
            successAnim.transform.localPosition = newPos;
            yield return null;
        }

        RestartGame();
    }
}
