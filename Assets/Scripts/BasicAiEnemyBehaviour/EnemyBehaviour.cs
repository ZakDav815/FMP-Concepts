using UnityEngine;
using System.Collections.Generic; // needed for public list<Transform> Locations;
using UnityEngine.AI; 

public class EnemyBehaviour : MonoBehaviour
{
    public Transform PatrolRoute;
    public List<Transform> locations;

    private int _locationIndex = 0;
    private NavMeshAgent _agent;
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        InitializePatrolRoute();

        MoveToNextPatrolLocation();
    }

    void InitializePatrolRoute()
    {
        foreach(Transform child in PatrolRoute)
        {
            locations.Add(child);
        }
    }
    void update()
    {
        if(_agent.remainingDistance < 0.2f && !_agent.pathPending)
        {
            MoveToNextPatrolLocation();
        }
    }

    void MoveToNextPatrolLocation()
    {
        if (locations.Count == 0)
        return;
        _agent.destination = locations[_locationIndex].position;
        _locationIndex = (_locationIndex + 1) % locations.Count;
    }
    void OnTriggerEnter(Collider other)
    {
        // ... No changes needed...
    }

    void OnTriggerExit(Collider other)
    {
        //...No changes needed...
    }
}