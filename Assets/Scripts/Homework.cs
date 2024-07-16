using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class Homework : MonoBehaviour
{
    [SerializeField] float num1;
    [SerializeField] float min, max;

    [SerializeField] float clamped;
    [SerializeField] float min_out;
    
    
    // Start is called before the first frame update

    private void OnValidate()
    {
        clamped = Clamp(num1, min, max);
        min_out = MyMin(min, max);
    }

    float Clamp(float num1, float min, float max)
    {
        if (num1 < min)
            return min;
        if (num1 > max)
            return max;

        return num1;
    }

    float MyMin(float a, float b)
    {
        return a > b ? b : a;
    }

    float Round(float number, float roundTo)
    {
        float reaminder = number % roundTo;
        float full = number - reaminder;

        float half = roundTo / 2;

        if (reaminder > half)
            return full + roundTo;
        return full;
    }

    bool IsPrime(int num1)
    { 
        for (int i = 2; i < num1 / 2; i++)
        {
            if (num1 % i == 0)
                return false;
        }

        return true;



    }

    Vector3 MoveTowards(Vector3 current, Vector3 target, float maxStep)
    {

        Vector3 direction = target - current;
        float distance = direction.magnitude;
        direction /= distance;  // Normalizálás - egszerûen
        //direction.Normalize();

        if (distance <= maxStep)
            return target;

        return current + direction * maxStep;
    }

}
