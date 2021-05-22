using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("I entered the triger");
        if(other.tag == "Player")

            other.GetComponent<B34AnimationController>().SetForwardSpeedParameter(0f);

        else

            other.GetComponent<A27AnimationController>().SetForwardSpeedParameter(0f);
    }

    private void OnTriggerExit(Collider other)
    {
        //Debug.Log("I left the triger");
        if (other.tag == "Player")

            other.GetComponent<B34AnimationController>().SetForwardSpeedParameter(1f);

        else

            other.GetComponent<A27AnimationController>().SetForwardSpeedParameter(1f);
    }
}
