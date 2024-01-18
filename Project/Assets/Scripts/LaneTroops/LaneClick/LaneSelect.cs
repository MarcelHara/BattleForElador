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

public class LaneSelect : MonoBehaviour
{
    /// <summary>
    /// OLD SCRIPT NOT USED TESTING PURPOSE
    /// </summary>


    public Transform Lane1;
    public Transform Lane2;
    public Transform Lane3;

    public GameObject troop;
    public GameObject troop2;
    public GameObject troop3;

    public Transform Spawn1;
    public Transform Spawn2;
    public Transform Spawn3;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform != null)
                {
                    if(hit.transform == Lane1)
                    {
                        Debug.Log("1");
                        Instantiate(troop, Spawn1.transform.position, Spawn1.transform.rotation);
                    }

                    if (hit.transform == Lane2)
                    {
                        Debug.Log("2");
                        Instantiate(troop2, Spawn2.transform.position, Spawn2.transform.rotation);
                    }

                    if (hit.transform == Lane3)
                    {
                        Debug.Log("3");
                        Instantiate(troop3, Spawn3.transform.position, Spawn3.transform.rotation);
                    }

                }
            }
        }
    }
}
