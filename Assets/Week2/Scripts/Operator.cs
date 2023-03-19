using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Operator_Arithmetic();
        //Operator_Assignment();
        //Operator_Comparison();
    }

    void Operator_Arithmetic()
    {
        int a = 10;
        int b = 20;
        int c;

        Debug.Log("a + b: " + (a + b));
        Debug.Log("a - b: " + (a - b));
        Debug.Log("a * b: " + (a * b));
        Debug.Log("a / b: " + (a / b));
        Debug.Log("a % b: " + (a % b));
        c = a++;    // The result is before increase
        Debug.Log("a++: " + c + ", a:" + a);
        c = ++b;    // The result is after increase
        Debug.Log("++b: " + c + ", b:" + b);
    }

    void Operator_Assignment()
    {
        int a = 3;
        int result = 1;

        result = a;
        Debug.Log("=: " + result);
        result += a;
        Debug.Log("+=: " + result);
        result -= a;
        Debug.Log("-=: " + result);
        result *= a;
        Debug.Log("*=: " + result);
        result /= a;
        Debug.Log("/=: " + result);
        result %= a;
        Debug.Log("%=: " + result);
    }

    void Operator_Comparison()
    {
        int a = 10;
        int b = 20;

        Debug.Log("a == b: " + (a == b));
        Debug.Log("a != b: " + (a != b));
        Debug.Log("a > b: " + (a > b));
        Debug.Log("a < b: " + (a < b));
        Debug.Log("a >= b: " + (a >= b));
        Debug.Log("a <= b: " + (a <= b));
        //Debug.Log("a =< b: " + (a =< b)); // The order is important
    }
}
