using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
    public Camera endingCam;
    public AudioClip endingSound;

    private void Start()
    {
        if (!GetComponent<AudioSource>())
            gameObject.AddComponent<AudioSource>();
    }
    public virtual void TriggerEnding()
    {
        FindObjectOfType<Canvas>().gameObject.SetActive(false);
        FindObjectOfType<BackgroundMusicManager>().gameObject.SetActive(false);
    }

    public virtual void StopEnding()
    {

    }

    public virtual void RestartGame()
    {
        SceneManager.LoadScene(1);
    }

    public virtual void PlayEndingSound(bool loop = false)
    {
        GetComponent<AudioSource>().clip = endingSound;
        GetComponent<AudioSource>().Play();
        GetComponent<AudioSource>().loop = loop;
    }
}
