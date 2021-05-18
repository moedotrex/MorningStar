using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SetDestination : MonoBehaviour
{
    public NavMeshAgent player2;
    public Transform player1;

    GameObject current;

    bool stopped = false;
    bool walkingEnabled = false;
    string currentTag;

    float distX, distZ;
    // Start is called before the first frame update
    void Start()
    {
        current = GameObject.FindWithTag(player2.tag);
        currentTag = player2.tag;
    }

    // Update is called once per frame
    void Update()
    {

        current = GameObject.FindWithTag(player2.tag);

        player2.SetDestination(player1.position);

        distX = Mathf.Abs(player2.transform.position.x - player1.position.x);
        distZ = Mathf.Abs(player2.transform.position.z - player1.position.z);


            if (!walkingEnabled)
            {
                //Debug.Log("I'm inside the walking but haven't told code to walk");
                if (distX > 1 || distZ > 1)
                {
                    if (currentTag == "Player")
                    {
                        current.GetComponent<B34AnimationController>().IsWalking(true);
                   //Debug.Log("started walk");
                }
                else
                    {
                        //current.GetComponent<A27AnimationController>().IsWalking(true);
                    }

                    walkingEnabled = true;
                }
            }

            else
            {
            //Debug.Log("I'm never here am I?");
            if (distX < 1 && distZ < 1)
                {
                    if (currentTag == "Player")
                    {
                        current.GetComponent<B34AnimationController>().StopTrigger();
                    //Debug.Log("stopped walk");
                }
                else
                    {
                        //current.GetComponent<A27AnimationController>().IsWalking(false);
                    }

                    walkingEnabled = false;
                }
            }
    }
}
