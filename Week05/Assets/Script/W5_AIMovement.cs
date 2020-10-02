using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class W5_AIMovement : MonoBehaviour
{
    private W5_Player_movement platerTarget;
    private NavMeshAgent navAgent;

    private void Start()
    {
        navAgent = this.GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        FindingPlayer();
        UpdateMovement();
    }

    private void UpdateMovement()
    {
        if (platerTarget == null)
            return;

        navAgent.SetDestination(platerTarget.transform.position);
    }

    private void FindingPlayer()
    {
        if (platerTarget == null)
        {
            platerTarget = FindObjectOfType<W5_Player_movement>();
        }
    }
}
