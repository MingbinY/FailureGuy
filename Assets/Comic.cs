using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Comic : MonoBehaviour
{
    public List<GameObject> comics;

    private void Start()
    {
        StartCoroutine(ComicSequence());
    }

    IEnumerator ComicSequence()
    {
        yield return null;
        int i = 0;
        while (i < comics.Count)
        {
            comics[i].SetActive(true);
            i ++;
            yield return new WaitForSeconds(1);
        }
        yield return new WaitForSeconds(3);

        SceneManager.LoadScene(1);
    }
}
