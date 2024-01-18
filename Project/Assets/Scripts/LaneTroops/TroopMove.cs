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

public class TroopMove : MonoBehaviour
{

    /// <summary>
    /// OLD SCRIPT NOT USED TESTING PURPOSE
    /// </summary>

    public NavMeshAgent agent;

    public GameObject[] waypoints;
    private int waypointInd = 1;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        agent.updatePosition = true;
        agent.updateRotation = true;


    }

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Lane1")
        {
            waypointInd = 1;
            Move();           
        }
        if (col.gameObject.tag == "Lane2")
        {
            waypointInd = 2;
            Move();
        }
        if (col.gameObject.tag == "Lane3")
        {
            waypointInd = 3;
            Move();
        }
    }

    void Move()
    {
        if (Vector3.Distance(this.transform.position, waypoints[waypointInd].transform.position) >= 2)
        {
            agent.SetDestination(waypoints[waypointInd].transform.position);

        }
        else if (Vector3.Distance(this.transform.position, waypoints[waypointInd].transform.position) <= 2)
        {
            waypointInd += 1;
            if (waypointInd >= waypoints.Length)
            {
                waypointInd = 0;
            }
        }
    }
}

