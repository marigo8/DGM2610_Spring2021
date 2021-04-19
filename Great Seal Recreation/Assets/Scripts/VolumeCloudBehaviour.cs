using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeCloudBehaviour : MonoBehaviour
{
    private Material mat;
    public float thickness;

    private void Start()
    {
        mat = GetComponent<MeshRenderer>().material;

        var defaultVector = mat.GetVector("Vector2_9D11B64");
        var offset = transform.localPosition.z * thickness;
        offset = Mathf.Abs(offset);
        Debug.Log(offset);
        Debug.Log(defaultVector);
        defaultVector.x += offset;
        mat.SetVector("Vector2_9D11B64", defaultVector);
    }
}
