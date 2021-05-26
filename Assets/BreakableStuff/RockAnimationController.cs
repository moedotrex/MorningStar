using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockAnimationController : MonoBehaviour
{

    Animator rockAnimator;

    // Start is called before the first frame update
    void Start()
    {

        rockAnimator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RebuildTrigger()
    {
        rockAnimator.SetTrigger("RebuildRock");
    }
}
