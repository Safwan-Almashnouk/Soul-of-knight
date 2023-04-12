using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationPos : MonoBehaviour
{
    public GameObject Player;
    public Vector3 position;
    void LateUpdate()
    {
        Animator animator = GetComponent<Animator>();
        AnimatorStateInfo currentAnimatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);
        float playbackTime = currentAnimatorStateInfo.normalizedTime * currentAnimatorStateInfo.length;
        if (currentAnimatorStateInfo.IsName("DodgeF") && playbackTime > 0.3f)
        {
            Player.transform.position -= transform.forward * Time.deltaTime;
        }
    }
}

