using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorPractice : MonoBehaviour
{
    void OnValidate()
    {

        Vector2 v2a = new Vector2(2, 3);
        Vector2 v2b = new(2, 6);
        // var v2c = new Vector2(5, 6);

        Vector3 v3a = new(2, 3, 4);
        Vector3 v3b = new(5, 6, 7);

        Vector3 v3e = Vector3.zero; // 0, 0, 0
        v3e = Vector3.right;        // 1, 0, 0
        v3e = Vector3.left;         // -1,0, 0
        v3e = Vector3.up;           // 0, 1, 0
        v3e = Vector3.down;         // 0, -1, 0
        v3e = Vector3.forward;      // 0, 0, 1
        v3e = Vector3.back;         // 0, 0, -1

        v3e = Vector3.one;         // 1, 1, 1

        v3e = v3a + v3b;
        v3e = v3a - new Vector3(2, 3, 4);

        float length = v3e.magnitude;       // vektor hossza

        Vector3 v3Nurm = v3e.normalized;    // normalizálás

        v3e.Normalize();                    // 

    }


}
