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

        //current = GameObject.FindWithTag(player2.tag);

        player2.SetDestination(player1.position);

        /*distX = Mathf.Abs(player2.transform.position.x - player1.position.x);
        distZ = Mathf.Abs(player2.transform.position.z - player1.position.z);

        Debug.Log("X: " + distX + "Y_ " + distZ);

        if (distX > 0.5 && distZ > 0.5)
        {
            if (currentTag == "Player")
            {
                current.GetComponent<B34AnimationController>().SetForwardSpeedParameter(1f);
            }

        }

        else
        {
            if (currentTag == "Player")
            {
                current.GetComponent<B34AnimationController>().SetForwardSpeedParameter(0f);
            }

        }*/
    }
}
