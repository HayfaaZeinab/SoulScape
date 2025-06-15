using UnityEngine;

public class SmoothAutoRotate : MonoBehaviour
{
    public float rotationSpeed = 10f;
    private Quaternion targetRotation;

    void Start()
    {
        targetRotation = transform.rotation;
    }

    void Update()
    {
        targetRotation *= Quaternion.Euler(0, rotationSpeed * Time.deltaTime, 0);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 0.1f);
    }
}
