using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudCreateBehaviour : MonoBehaviour
{
    public GameObject prefab;
    public int layerCount;
    public float spread;

    public void Start()
    {
        for(var i = 0; i < layerCount; i++)
        {
            var position = transform.position;
            position.y += (i*1f) / layerCount * spread;

            var layer = Instantiate(prefab, position, transform.rotation);
            var mat = layer.GetComponent<MeshRenderer>().material;

            var baseValue = mat.GetVector("Vector2_5B0DD8CC");

            var step = Mathf.PingPong(((i * 1f) / layerCount) * 2, .9f);
            baseValue.x = Mathf.Lerp(.9f, baseValue.x, step);
            baseValue.x = Mathf.Clamp(baseValue.x, 0, .89f);

            mat.SetVector("Vector2_5B0DD8CC", baseValue);
        }
    }
}
