using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewindRock : MonoBehaviour
{

    GameObject rock;

    // Update is called once per frame
    void RewindEvent()
    {
        rock = GameObject.FindGameObjectWithTag("Rock");
        rock.GetComponent<RockAnimationController>().RebuildTrigger();
    }
}
