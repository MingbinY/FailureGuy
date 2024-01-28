using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    IEnumerator EndSequence()
    {
        yield return new WaitForSeconds(1.0f);
        if (endingObj != null)
        {
            endingObj.TriggerEnding();
        }
    }
}
