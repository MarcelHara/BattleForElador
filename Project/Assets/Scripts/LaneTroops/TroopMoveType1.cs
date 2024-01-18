/* Copyright 2021 Joel Squires-Purnell

Licensed under the MIT License, you may not use this file except in compliance with the License.

You may obtain a copy of the License at https://opensource.org/licenses/MIT

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. 
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TroopMoveType1 : MonoBehaviour
{

    public NavMeshAgent agent;
    

    public GameObject waypoint;

    public void END()
    {
        GetComponent<RadiusCheck>().FaceTarget();
        GetComponent<RadiusCheck2>().FaceTarget();
        agent.isStopped = true;
        
        Debug.Log("STOP FR THIS TIME");
    }

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        agent.updatePosition = true;
        agent.updateRotation = true;
        
        
    }

    //on collision with anything (the floor in this instance) move the character
    public void OnCollisionEnter(Collision col)
    {
        Move();
    }

    public void Move()
    {
        float distance = Vector3.Distance(waypoint.transform.position, this.transform.position);
        //if the distance to the waypoint is less then 2 away in distance value, move to the function
        if (Vector3.Distance(this.transform.position, waypoint.transform.position) >= 0.5)
        {
            //move troop by using the nav mesh agent to the waypoints position
            agent.SetDestination(waypoint.transform.position);
                       
           // if (distance <= agent.stoppingDistance)
           // {
           //     agent.isStopped = true;
           //     waypoint = null;
           //     Debug.Log("STOPPING");
           // }

        }
    }



}
