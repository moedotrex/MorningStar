using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SetDestination : MonoBehaviour
{
    public NavMeshAgent player2;
    public Transform player1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player2.SetDestination(player1.position);
    }
}
