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
    public Animator anim;
    private AnimatorStateInfo stateInfo;
    public bool isPlayed = false;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {

        AnimatorStateInfo stateInfo = anim.GetCurrentAnimatorStateInfo(0);

        // 如果是按钮动画就把手臂也隐藏掉
        if(stateInfo.IsName("Button")){
            GameObject.Find("Hand").SetActive(false);
        }

        //动画播放完之后把自己隐藏掉,顺便把手臂“放”出来
        if (!stateInfo.IsName(gameObject.name) && isPlayed) {
            Debug.Log(stateInfo.normalizedTime);
            gameObject.SetActive(false);
            GameObject.Find("Hand").SetActive(true);
        }

    }
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

        anim.Play(gameObject.name);
        isPlayed = true;

        Debug.Log(name);
    }
}
