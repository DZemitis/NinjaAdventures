using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Serialization;

public class AIMove : MonoBehaviour
{
    [FormerlySerializedAs("_destination")] [SerializeField] public Transform Destination;

    [FormerlySerializedAs("_navMeshAgent")] public NavMeshAgent NavMeshAgent;

    void Start()
    {
        NavMeshAgent = this.GetComponent<NavMeshAgent>();

        if (NavMeshAgent == null)
        {
            Debug.LogError("The nav mesh agent component is not attached to" + gameObject.name);
        }
        else
        {
            SetDestination();
        }
    }

    private void SetDestination()
    {
        if (Destination != null)
        {
            Vector3 targetVector3 = Destination.transform.position;
            NavMeshAgent.SetDestination(targetVector3);
        }

    }
}
