using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Cinemachine;

public class CharacterSwap : MonoBehaviour
{

    public GameObject p1, p2;
    GameObject active, cam;
    Transform navMeshDist;

    // Start is called before the first frame update
    void Start()
    {
        p1 = GameObject.FindWithTag("Player");
        p2 = GameObject.FindWithTag("Player2");
        cam = GameObject.FindWithTag("Brain");

        active = p1;
        active.GetComponent<B34PlayerController>().enabled = true;
        active.GetComponent<SetDestination>().enabled = false;
        active.GetComponent<NavMeshAgent>().enabled = false;
        active.GetComponent<CharacterController>().enabled = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("x"))
        {
            if (active == p1)
            {

                active.GetComponent<B34PlayerController>().enabled = false;
                active.GetComponent<SetDestination>().enabled = true;
                active.GetComponent<NavMeshAgent>().enabled = true;
                active.GetComponent<CharacterController>().enabled = false;

                active = p2;

                active.GetComponent<A27PlayerController>().enabled = true;
                active.GetComponent<SetDestination>().enabled = false;
                active.GetComponent<NavMeshAgent>().enabled = false;
                active.GetComponent<CharacterController>().enabled = true;

                cam.GetComponent<CinemachineFreeLook>().LookAt = active.transform;
                cam.GetComponent<CinemachineFreeLook>().Follow = active.transform;
            }

            else
            {
                active.GetComponent<A27PlayerController>().enabled = false;
                active.GetComponent<SetDestination>().enabled = true;
                active.GetComponent<NavMeshAgent>().enabled = true;
                active.GetComponent<CharacterController>().enabled = false;

                active = p1;

                active.GetComponent<B34PlayerController>().enabled = true;
                active.GetComponent<SetDestination>().enabled = false;
                active.GetComponent<NavMeshAgent>().enabled = false;
                active.GetComponent<CharacterController>().enabled = true;

                cam.GetComponent<CinemachineFreeLook>().LookAt = active.transform;
                cam.GetComponent<CinemachineFreeLook>().Follow = active.transform;
            }
        }
        
        
    }
}
