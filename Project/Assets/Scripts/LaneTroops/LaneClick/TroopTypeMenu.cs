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

public class TroopTypeMenu : MonoBehaviour
{
    public GameObject ElButton;

    public GameObject close1;
    public GameObject close2;
    
    /// <summary>
    /// This is a script to turn on and off the lane selection for characters)
    /// </summary>

    // Start is called before the first frame update
    public void Active()
    {
        ElButton.SetActive(true);
        close1.SetActive(false);
        close2.SetActive(false);
    }
}
