using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondTestScript : MonoBehaviour
{

    [SerializeField] float test;
    void OnValidate() // Eljárás
    {
        test = MyAbs(-4.3f);
    }

    void WriteNumbersFrom1(int length = 10)
    {
        for (int i = 1; i <= length; i++)
        {
            Debug.Log(i);
        }
    }

    void WriteNumbersSequenced(int from, int to)
    {
        if (from > to)
        {
            return;
        }
        
        for (int i = from; i <= to; i++)
        {
            Debug.Log(i);
        }
    }

    public float MyPower(int baseNumber, int exponent)
    {
        int res = 1;
        for (int i = 0; i < exponent; i++)
        {
            res *= baseNumber;
        }

        return res;
    }


    float MyAbs(float num)
    {
        return num < 0 ? -num : num;
    }

}
