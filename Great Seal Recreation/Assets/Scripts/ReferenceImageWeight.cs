using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

[ExecuteAlways]
public class ReferenceImageWeight : MonoBehaviour
{
    [Range(0f, 1f)]
    public float weight;

    public Image img;
    public Volume volume;

    private void Update()
    {
        var color = img.color;
        color.a = weight;
        img.color = color;

        volume.weight = 1 - weight;
    }
}
