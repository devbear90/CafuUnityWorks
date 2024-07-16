using UnityEngine;

class SpaceShipController : MonoBehaviour
{
    [SerializeField] float maxSpeed = 2;
    [SerializeField] float angularSpeed = 180;
    [SerializeField] float acceleration = 2;
    [SerializeField] float drag = 0.5f;

    Vector3 velocity;

    void Update()
    {
        float inputx = Input.GetAxisRaw("Horizontal");           
        
        // mozg�s
        transform.position += velocity * Time.deltaTime;

        transform.Rotate(0, 0, -inputx * angularSpeed * Time.deltaTime);

        //Quaternion rot = transform.rotation;
        //Vector3 eulerRotation = rot.eulerAngles;
        //eulerRotation.z -= inputx * angularSpeed * Time.deltaTime;

        //transform.rotation = Quaternion.Euler(eulerRotation);

    }
    void FixedUpdate()
    {
        float inputy = Input.GetAxisRaw("Vertical");
        // gyorsul�s
        Vector3 direction = transform.up * Mathf.Max(inputy, 0);
        velocity += direction * acceleration * Time.fixedDeltaTime;

        //if (velocity.magnitude > maxSpeed)      // velocity.magnitude -> velocity nagys�ga
        //    velocity = velocity.normalized * maxSpeed;
        velocity = Vector3.ClampMagnitude(velocity, maxSpeed);

        // k�zegellen�ll�s

        velocity -= velocity * drag * Time.fixedDeltaTime;
    }
}
