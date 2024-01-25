using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteManager : MonoBehaviour
{
   public void FadeIn(SpriteRenderer sprite, float time)
    {
        StartCoroutine(FadeInEnum(sprite, time));
    }

    public void FadeOut(SpriteRenderer sprite, float time)
    {
        StartCoroutine (FadeOutEnum(sprite, time));
    }

    IEnumerator FadeInEnum(SpriteRenderer sprite, float fadeTime)
    {
        yield return null;
        sprite.color = new Color(sprite.color.r, sprite.color.g, sprite.color.b, 0);
        for (float i = 0; i <= 1; i += Time.deltaTime/ fadeTime)
        {
            sprite.color = new Color(sprite.color.r, sprite.color.g, sprite.color.b, i);
            yield return null;
        }
    }

    IEnumerator FadeOutEnum(SpriteRenderer sprite, float fadeTime)
    {
        yield return null;
        sprite.color = new Color(sprite.color.r, sprite.color.g, sprite.color.b, 1);
        for (float i = 1; i >=0; i -= Time.deltaTime / fadeTime)
        {
            sprite.color = new Color(sprite.color.r, sprite.color.g, sprite.color.b, i);
            yield return null;
        }
    }
}
