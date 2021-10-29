using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    [Range(1, 10)]
    public float smoothFactor;

    private void FixedUpdate()
    {
        Seuraa();
    }
    void Seuraa()
    {
        Vector3 targetposition = target.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, targetposition, smoothFactor * Time.fixedDeltaTime);
        transform.position = smoothPosition;
    }
}
