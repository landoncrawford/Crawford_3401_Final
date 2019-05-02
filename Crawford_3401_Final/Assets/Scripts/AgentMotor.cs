using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentMotor : MonoBehaviour

{
    public NavMeshAgent agent;

    public float moveSpeed;

    public Vector3 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        agent.speed = moveSpeed;
        agent.SetDestination(targetPosition);
        if (Input.GetMouseButtonDown(0))
        {
            Ray cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(cameraRay, out hit))
            {
                targetPosition = new Vector3(hit.point.x, hit.point.y + 1f, hit.point.z);
                
            }

        }
        
        
    }
}
