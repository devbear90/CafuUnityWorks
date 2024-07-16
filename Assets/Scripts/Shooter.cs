using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject bulletProrotype;
    void Update()
    {
        bool isFire = Input.GetKeyDown(KeyCode.Space);

        if (isFire)
        {
            GameObject newBullet = Instantiate(bulletProrotype);
            newBullet.transform.position = transform.position;
            newBullet.transform.rotation = transform.rotation;
        }
    }
}
