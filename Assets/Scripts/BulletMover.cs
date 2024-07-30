using UnityEngine;

public class BulletMover : MonoBehaviour
{
    [SerializeField] float speed = 10;
    [SerializeField] float duration = 3;

    //float startTime;

    ///float timeLeft;

    private void Start()
    {
        //startTime = Time.time;
        ///timeLeft = duration;
        //Invoke(nameof(DestroyGameObject), duration);

        Destroy(gameObject, duration);
    }

    void DestroyGameObject()
    {
        Destroy(gameObject, duration);
    }

    void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;
        //float age = Time.time - startTime;
        ///timeLeft -= Time.deltaTime;

        //if (age > duration)
        
        ////if(timeLeft<=0)
           /// Destroy(gameObject);

    }




}
