using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    public string m_anim = "Button";
    public Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void OnTriggerEnter(Collider collision)
    {
        anim.Play(m_anim);
    }
}
