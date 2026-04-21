using UnityEngine;
using System.Collections.Generic; // needed for public list<Transform> Locations;
using UnityEngine.AI; 

public class EnemyBehaviour : MonoBehaviour
{
    public Transform PatrolRoute;
    public List<Transform> Locations;

    private int _LocationIndex = 0;
    private NavMeshAgent _Agent;
    void Start()
    {
        _Agent = GetComponent<NavMeshAgent>();
        InitializePatrolRoute();

        MoveToNextPatrolRoute();
    }

    void InitializePatrolRoute()
    {
        foreach(Transform child in PatrolRoute)
        {
            Locations.Add(child);
        }
    }
    
    void MoveToNextPatrolLocation()
    {
        _Agent.destination = Locations[_LocationIndex].position;
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