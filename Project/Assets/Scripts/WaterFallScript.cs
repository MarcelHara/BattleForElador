using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterFallScript : MonoBehaviour
{
    Animation animate;

    private void Start()
    {
        animate = GetComponent<Animation>();
        animate.wrapMode = WrapMode.Loop;
    }

    private void Update()
    {
        foreach (AnimationState animState in animate)
        {
            animState.speed = 0.8f;
        }

    }
}
