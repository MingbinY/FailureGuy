using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum EndingType
{
    success,
    frog,
    button,
    keyhole,
    other,
}
public class EndingTrigger : MonoBehaviour
{
    public EndingType ending = EndingType.other;

    public Ending endingObj;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collide");
        HandRotate handRotate = other.GetComponent<HandRotate>();
        HandMove handMove = other.GetComponent<HandMove>();
        if (endingObj)
        {
            if (handRotate != null)
            {
                handRotate.StopRotate();
            }
            if (handMove != null)
            {
                handMove.StopMoving();
            }

            StartCoroutine(EndSequence());
        }
        else
        {
            StartCoroutine(RestartGameSequence());
        }
    }

    IEnumerator EndSequence()
    {
        yield return new WaitForSeconds(1.0f);
        if (endingObj != null)
        {
            endingObj.TriggerEnding();
        }
    }

    IEnumerator RestartGameSequence()
    {
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene(1);
    }
}
