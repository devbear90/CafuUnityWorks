using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenTeleporter : MonoBehaviour
{
    Collider2D collider2D;
    Camera myCamera;

    private void Start()
    {
        //spriteRenderer = GetComponent<SpriteRenderer>(); // saját magamról kérem le az objectet
        myCamera = FindAnyObjectByType<Camera>();
        //camera = Camera.main; // Fõ kamerát lekéri
        collider2D = GetComponent<Collider2D>();
    }
    private void Update()
    {
        Rect cameraRect = GetCameraRect();
        Rect selfRect = GetSelfRect();
    }

    private Rect GetSelfRect()
    {
        Bounds bounds = collider2D.bounds;
        return new Rect(bounds.min, bounds.size);
    }

    Rect GetCameraRect()
    {
        Vector2 center = myCamera.transform.position;
        float y = myCamera.orthographicSize * 2;
        float x = myCamera.aspect * y;

        Vector2 size = new Vector2(x, y);   

        return new Rect(center - size/2, size);

    }

    void OnDrawGizmos()
    {
        if (myCamera == null) return;
        if (collider2D == null) return;

        Rect cameraRect = GetCameraRect();
        Rect selfRect = GetSelfRect();
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(cameraRect.center, cameraRect.size);
        Gizmos.DrawWireCube(collider2D.bounds.center, collider2D.bounds.size);
    }
}
