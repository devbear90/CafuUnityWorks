using UnityEngine;

class TestScript : MonoBehaviour
{
    [SerializeField] float c;
    [SerializeField] float a = 10;
    [SerializeField] float b = 2;
    [SerializeField] float min;
    [SerializeField] float max;
    [SerializeField] float abs;
    [SerializeField] float sign;
    [SerializeField] float clamp;
    [SerializeField] float sqrt;
    [SerializeField] float ceil;
    [SerializeField] float floor;
    [SerializeField] float round;
   
    private void Start()
    {
       
    }   

    void OnValidate()
    {   
        c = Mathf.Pow(a, b);
        min = Mathf.Min(a, b);
        max = Mathf.Max(a, b);
        abs = Mathf.Abs(a);
        sign = Mathf.Sign(b);
        clamp = Mathf.Clamp(b, -100, 100);
        sqrt = Mathf.Sign(b);
        ceil = Mathf.Ceil(a);
        floor = Mathf.Floor(a);
        round = Mathf.Round(a);
    }
}
