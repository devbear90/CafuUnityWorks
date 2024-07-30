using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerWithDistance : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Transform target;
    [SerializeField] float minDistance;
    [SerializeField] Color gizmoColor;

    /* private void Start()
     {
         target = GameObject.Find("Cube"); // string alapú keresést kerüljük
     }*/

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, GetRealTarget(), speed * Time.deltaTime);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = gizmoColor;
        Gizmos.DrawWireSphere(target.position, minDistance);
        Gizmos.DrawLine(target.position, transform.position);

        Gizmos.color = Color.red;
        Vector3 realTargetPoint = GetRealTarget();
        Gizmos.DrawSphere(realTargetPoint, 0.2f);

    }

    Vector3 GetRealTarget()
    {
        Vector3 self = transform.position;
        Vector3 other = target.position;
        Vector3 direction = (other - self).normalized;
        Vector3 realTargetPoint = other - (direction * minDistance);
        return realTargetPoint;
    }
}

