using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class ImageOpacity : MonoBehaviour
{
    public Image image;
    public Color color = Color.white;
    private void Update()
    {
        if(image == null)
        {
            image = GetComponent<Image>();
        }
        color.a = Mathf.PingPong(Time.time, 1f);

        image.color = color;
    }
}
