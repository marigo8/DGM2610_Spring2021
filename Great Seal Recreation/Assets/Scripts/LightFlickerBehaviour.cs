using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Light))]
public class LightFlickerBehaviour : MonoBehaviour
{
    public Gradient flickerPattern;
    public float flickerMultiplier;

    private Light lightComp;

    private float baseIntensity;
    private float step;

    private void Start()
    {
        lightComp = GetComponent<Light>();
        baseIntensity = lightComp.intensity;
    }

    private void Update()
    {
        step += Time.deltaTime;
        step %= 1;

        var intensity = flickerPattern.Evaluate(step).r;

        lightComp.intensity = baseIntensity + intensity * flickerMultiplier;
    }
}
