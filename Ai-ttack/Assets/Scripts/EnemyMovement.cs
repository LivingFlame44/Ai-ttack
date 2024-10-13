using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public Transform target;
    public float speed;
    NavMeshAgent agent;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        //target = Camera.main.ScreenToWorldPoint(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        SetAgentPosition();
    }

    public void SetAgentPosition()
    {
        agent.SetDestination(target.position);
    }
}
