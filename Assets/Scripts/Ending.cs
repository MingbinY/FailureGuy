using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
    public Camera endingCam;

    public virtual void TriggerEnding()
    {

    }

    public virtual void StopEnding()
    {

    }

    public virtual void RestartGame()
    {
        SceneManager.LoadScene(1);
    }
}
