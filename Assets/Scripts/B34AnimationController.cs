using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B34AnimationController : MonoBehaviour
{
    Animator b34Animator;
    PlayerController b34Movement;

    // Start is called before the first frame update
    void Start()
    {
        b34Animator = GetComponent<Animator>();

    }

    public void IsWalking(bool isWalking)
    {
        b34Animator.SetBool("IsWalking", isWalking);
    }


    // Update is called once per frame
    void Update()
    {
        //bool IsWalking = b34Animator.GetBool("IsWalking");
        bool forwardPressed = Input.GetKey("w");

        if (forwardPressed)
        {
            b34Animator.SetBool("IsWalking", true);
        }

        if (!forwardPressed)
        {
            b34Animator.SetBool("IsWalking", false);
        }
    }
}
