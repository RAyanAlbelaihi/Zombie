using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class zombieController : MonoBehaviour
{
    public Transform target; // Reference to the player's transform
    private NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (target != null)
        {
            // Set the player as the zombie's destination
            agent.SetDestination(target.position);
        }
    }
}
