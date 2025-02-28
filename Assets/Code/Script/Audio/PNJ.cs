using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PNJ : MonoBehaviour
{
    [SerializeField] private NavMeshAgent _agent;
    [SerializeField] private List<Transform> _waypoints;
    [SerializeField] private float _waypointThreshold = 0.5f;
    [SerializeField] private bool _loop = true;

    private int currentWaypointIndex = 0;

    void Start()
    {
        MoveToNextWaypoint();
    }

    void Update()
    {
        if (!_agent.pathPending && _agent.remainingDistance < _waypointThreshold)
        {
            NextWaypoint();
        }
    }

    void MoveToNextWaypoint()
    {
        if (currentWaypointIndex < _waypoints.Count)
        {
            _agent.SetDestination(_waypoints[currentWaypointIndex].position);
        }
    }

    void NextWaypoint()
    {
        currentWaypointIndex++;

        if (currentWaypointIndex >= _waypoints.Count)
        {
            if (_loop)
            {
                currentWaypointIndex = 0;
            }
            else
            {
                _agent.isStopped = true;
                return;
            }
        }

        MoveToNextWaypoint();
    }
}
