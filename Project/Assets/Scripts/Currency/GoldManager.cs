/* Copyright 2021 Joel Squires-Purnell

Licensed under the MIT License, you may not use this file except in compliance with the License.

You may obtain a copy of the License at https://opensource.org/licenses/MIT

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. 
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.*/


using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GoldManager : MonoBehaviour
{
    public int GoldValue = 2;
    
    public double DelayAmount = 1; // Second count
    public Text GoldValueText;
    public GameObject upgrade1;
    public GameObject upgrade2;
    public GameObject upgrade3;
    public GameObject upgrade4;


    protected float Timer;

    private void Start()
    {
        GoldValue = 100;
        //GoldValueText = GetComponent<TextMeshProUGUI>();

        if(!GoldValueText)
        {
            Debug.LogError("Object not found");
        }
    }

    void Update()
    {
        Timer += Time.deltaTime;

        if (Timer >= DelayAmount)
        {
            Timer = 0f;            
            GoldValue++; // For every DelayAmount or "second" it will add one to the GoldValue
            GoldValueText.text = "GOLD: " + GoldValue;
        }
    }

    public void Upgrade1()
    {
        if (GoldValue >= 150)
        {
            DelayAmount = 0.5;
            GoldValue -= 150;
            Destroy(upgrade1);
        }
        
    }
    public void Upgrade2()
    {
        if (GoldValue >= 300)
        {
            DelayAmount = 0.45;
            GoldValue -= 300;
            Destroy(upgrade2);
        }
        
    }
    public void Upgrade3()
    {
        if (GoldValue >= 450)
        {
            DelayAmount = 0.35;
            GoldValue -= 450;
            Destroy(upgrade3);
        }
        
    }
    public void Upgrade4()
    {
        if (GoldValue >= 600)
        {
            DelayAmount = 0.25;
            GoldValue -= 600;
            Destroy(upgrade4);
        }
    }
    public void Warrior()
    {
        if (GoldValue >= 50)
        {
            GoldValue -= 50;
            //lane1button
        }
    }
    public void Mage()
    {
        if (GoldValue >= 200)
        {
            GoldValue -= 200;
            //lane1button
        }
    }
    public void Healer()
    {
        if (GoldValue >= 100)
        {
            GoldValue -= 100;
            //lane1button
        }
    }
    public void Brute()
    {
        if (GoldValue >= 150)
        {
            GoldValue -= 150;
            //lane1button
        }
    }
    public void Assassin()
    {
        if (GoldValue >= 75)
        {
            GoldValue -= 75;
            //lane1button
        }
    }
    public void Archer()
    {
        if (GoldValue >= 75)
        {
            GoldValue -= 75;
            //lane1button
        }
    }
}
