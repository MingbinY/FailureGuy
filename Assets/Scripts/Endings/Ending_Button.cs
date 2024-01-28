using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending_Button : Ending
{
    public GameObject buttonAnim;
    public List<GameObject> character;
    public override void TriggerEnding()
    {
        base.TriggerEnding();
        StartCoroutine(ButtonEnding());
    }

    IEnumerator ButtonEnding()
    {
        foreach (GameObject character in character)
        {
            character.SetActive(false);
        }
        yield return null;
        //Switch Cam
        endingCam.gameObject.SetActive(true);
        Camera.main.gameObject.SetActive(false);
        yield return new WaitForSeconds(1f);
        buttonAnim.SetActive(true);
        FindObjectOfType<SpriteManager>().FadeIn(buttonAnim.GetComponent<SpriteRenderer>(), 3f);

        yield return new WaitForSeconds(5f);

        RestartGame();
    }
}
