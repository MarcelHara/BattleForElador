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

public class AIenemySpawn : MonoBehaviour
{
    public Transform spawnEnemy;
    public GameObject Warrior;
    public GameObject Mage;
    public GameObject Healer;
    public GameObject Brute;
    public GameObject Assassin;
    public GameObject Archer;

    public int RandomPref;
    public int Time;
    // Start is called before the first frame update
    void Start()
    {
        timeCheck();
    }

    void timeCheck()
    {
        RandomPref = Random.Range(1, 6);

        if (RandomPref == 1)
        {
            Invoke("SpawnWarrior", Time);
            ResetTime();            
        }
        else if (RandomPref == 2)
        {
            Invoke("SpawnMage", Time);
            ResetTime();
        }
        else if (RandomPref == 3)
        {
            Invoke("SpawnHealer", Time);
            ResetTime();
        }
        else if (RandomPref == 4)
        {
            Invoke("SpawnBrute", Time);
            ResetTime();
        }
        else if (RandomPref == 5)
        {
            Invoke("SpawnAssassin", Time);
            ResetTime();
        }
        else if (RandomPref == 6)
        {
            Invoke("SpawnArcher", Time);
            ResetTime();
        }
    }

    void ResetTime()
    {
        RandomPref = Random.Range(1, 6);
        Invoke("timeCheck", Time);
    }

    // Update is called once per frame
    void Update()
    {             

    }

    void SpawnWarrior()
    {
        Instantiate(Warrior, spawnEnemy.transform.position, spawnEnemy.transform.rotation);
    }

    void SpawnMage()
    {
        Instantiate(Mage, spawnEnemy.transform.position, spawnEnemy.transform.rotation);
    }

    void SpawnHealer()
    {
        Instantiate(Healer, spawnEnemy.transform.position, spawnEnemy.transform.rotation);
    }

    void SpawnBrute()
    {
        Instantiate(Brute, spawnEnemy.transform.position, spawnEnemy.transform.rotation);
    }

    void SpawnAssassin()
    {
        Instantiate(Assassin, spawnEnemy.transform.position, spawnEnemy.transform.rotation);
    }

    void SpawnArcher()
    {
        Instantiate(Archer, spawnEnemy.transform.position, spawnEnemy.transform.rotation);
    }
}
