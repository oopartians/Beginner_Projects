using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataType : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Datatype_Integer();
        Datatype_FloatingPoint();
        Datatype_Character();
        Datatype_String();
        Datatype_Boolean();
    }

    void Datatype_Integer()
    {
        int n1 = 50;    // Assignment with declaration
        int n2;         // Declaration first
        n2 = 100;       // Assignment later

        long sum = n1 + n2;

        Debug.LogFormat("n1: {0}, n2: {1}, sum: {2}", n1, n2, sum);
    }

    void Datatype_FloatingPoint()
    {
        float f = 5.2f; // Values ??of type float must have an 'f' after the numeric value!
        double d = 10.5;

        Debug.LogFormat("f: {0}, d: {1}", f, d);
    }

    void Datatype_Character()
    {
        char ch1 = 'A';
        char ch2 = '\n';

        Debug.LogFormat("ch1: {0}, ch2: {1}", ch1, ch2);
    }

    void Datatype_String()
    {
        string text1 = "Hello World!";
        string text2 = "\\n is a new line character.\nNew Line!";

        string text3 = "Pen Pinapple ";
        string text4 = "Apple Pen";

        Debug.LogFormat("text1: {0}, text2: {1}, text3 + text4: {2}", text1, text2, text3 + text4);
    }

    void Datatype_Boolean()
    {
        bool isNumeric = false;
        bool isBoolean = true;

        Debug.LogFormat("isNumeric: {0}, isBoolean: {1}", isNumeric, isBoolean);
    }
}
