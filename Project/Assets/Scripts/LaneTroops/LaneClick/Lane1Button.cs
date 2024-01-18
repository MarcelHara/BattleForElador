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

public class Lane1Button : MonoBehaviour
{    
    public GameObject troop;    
    public Transform Spawn1;
    
    /// <summary>
    /// This Script hosts a instantiate function to spawn a troop at a spawns position
    /// </summary>
    public void Button()
    {
        Instantiate(troop, Spawn1.transform.position, Spawn1.transform.rotation);
    }

    private void TroopSpawner()
    {
        
        Instantiate(troop, Spawn1.transform.position, Spawn1.transform.rotation);
    }

}
