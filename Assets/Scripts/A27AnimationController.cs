using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A27AnimationController : MonoBehaviour
{
    Animator a27Animator;
    //B34PlayerController b34Movement;

    // Start is called before the first frame update
    void Start()
    {
        a27Animator = GetComponent<Animator>();

    }

    public void IsWalking(bool isWalking)
    {
        a27Animator.SetBool("IsWalking", isWalking);
    }

    /*public void SetForwardSpeedParameter(float forwardSpeed)
    {
        a27Animator.SetFloat("ForwardSpeed", forwardSpeed);
    }

    public void JumpTrigger()
    {
        a27Animator.SetTrigger("JumpTrigger");
    }*/

}