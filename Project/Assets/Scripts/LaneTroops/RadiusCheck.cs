using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Animations;

public class RadiusCheck : MonoBehaviour
{

    public float lookRadius = 10f;
    NavMeshAgent agent;
    public Rigidbody rb;
    Transform target;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }


    // Update is called once per frame
    public void Update()
    {
        target = GameObject.FindWithTag("Enemy").transform;
        agent = GetComponent<NavMeshAgent>();
        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <= agent.stoppingDistance)
        {
            FaceTarget();
            Debug.Log("Facing");
        }

        if (distance <= lookRadius)
        {
            this.GetComponent<NavMeshAgent>().SetDestination(target.position);
            Debug.Log("enemydeteced");
        }

    }

    public void FaceTarget()
    {
        rb.velocity = new Vector3(0, 0, 0);
        rb.angularVelocity = Vector3.zero;
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
