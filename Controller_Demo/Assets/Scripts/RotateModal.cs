using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateModal : MonoBehaviour
{
    public float rotationSpeed;

    void Update()
    {
        OnMouseDrag();
    }

    private void OnMouseDrag()
    {
        float XaxisRotation = Input.GetAxis("Mouse X") * rotationSpeed;
        transform.RotateAround(Vector3.down, XaxisRotation);
    }
}
