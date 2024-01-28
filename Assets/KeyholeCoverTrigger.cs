using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyholeCoverTrigger : MonoBehaviour
{
    public GameObject coverObj;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<HandMove>() != null)
        {
            coverObj.SetActive(true);
        }
    }
}
