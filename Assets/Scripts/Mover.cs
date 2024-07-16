using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float speed;
    void Update()   // minden egyes képfrissítésnél meghívódik egyszer
    {
        float xDir = Input.GetAxisRaw("Horizontal");
        float yDir = Input.GetAxisRaw("Vertical");


        Vector3 direction = new(xDir, 0, yDir);

        direction.Normalize();


        Vector3 velocity = direction * speed;
        transform.position += velocity * Time.deltaTime ;
    }

    float GetDirection(KeyCode positive, KeyCode negative)
    {
        bool dPositive = Input.GetKey(positive);
        bool dNegative = Input.GetKey(negative);

        float dir = 0;


        if (dPositive)
            dir += 1;
        if (dNegative)
            dir -= 1;

        return dir;
    }

}
