using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieController : MonoBehaviour
{
    public CharacterController controller;
    private NavMeshAgent agent = null;
    private Transform target;




    // Start is called before the first frame update
    public void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {

        MoveToTarget();
        RotateToTarget();

    }

    void MoveToTarget()
    {
        
        agent.SetDestination(target.position);
    }

    void RotateToTarget()
    {
        transform.LookAt(target);
    }
}
