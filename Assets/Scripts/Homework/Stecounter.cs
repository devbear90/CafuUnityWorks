using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stecounter : MonoBehaviour
{
    [SerializeField] Vector2 a, b;
    [SerializeField] int jumpCount;
    [SerializeField] Vector2 jump;

    private void OnValidate()
    {

        Vector2 distanceVector = b - a;
        float distance = distanceVector.magnitude; // vektor hossza
        jumpCount = Mathf.CeilToInt(distance);
        jump = distanceVector / jumpCount;

    }
}
