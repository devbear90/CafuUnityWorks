using UnityEngine;

public class CircleScript : MonoBehaviour
{

    [SerializeField] float radius = 0f; // sug�r
    [SerializeField] float circumference; // ker�let
    [SerializeField] float area; // ter�let

    const float pi_num = Mathf.PI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnValidate()
    {
        circumference = 2 * radius * pi_num;
        area = radius * radius * pi_num;    // ez gyorsabb sokkal

        area = Mathf.Pow(radius, 2) * pi_num;
    }
}
