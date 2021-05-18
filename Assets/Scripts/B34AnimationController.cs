using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B34AnimationController : MonoBehaviour
{
    Animator b34Animator;
    B34PlayerController b34Movement;

    // Start is called before the first frame update
    void Start()
    {
        b34Animator = GetComponent<Animator>();

    }

    public void IsWalking(bool isWalking)
    {
        b34Animator.SetBool("IsWalking", isWalking);
    }

    public void SetForwardSpeedParameter(float forwardSpeed)
    {
        b34Animator.SetFloat("ForwardSpeed", forwardSpeed);
    }

    public void JumpTrigger()
    {
        b34Animator.SetTrigger("JumpTrigger");
    }

    public void StopTrigger()
    {
        b34Animator.SetTrigger("Stop");
    }

}
