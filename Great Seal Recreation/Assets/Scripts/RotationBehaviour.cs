using UnityEngine;

public class RotationBehaviour : MonoBehaviour
{
    public Vector3 rotateSpeed;

    private void Update()
    {
        transform.localEulerAngles += rotateSpeed * Time.deltaTime;
    }
}
