using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataType : MonoBehaviour
{
    // Duplicate code line: ctrl + d
    // code line comment: ctrl + k + c
    // code line uncomment: ctrl + k + u
    void Start()
    {
        Datatype_Integer();
        //Datatype_FloatingPoint();
        //Datatype_Character();
        //Datatype_String();
        //Datatype_Boolean();
        //Datatype_TypeCast();
        //Datatype_Default();
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

        Debug.LogFormat("ch1: {0}, ch2: {1}New Line!", ch1, ch2);
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

    void Datatype_TypeCast()
    {
        int num1 = 3;
        float num2 = 3.62f;

        //int num3 = num2;  // Error, need typecasting
        float num3 = num1;

        Debug.LogFormat("num1 + num2: {0}", num1 + num2);           // By default, the result is a data type with a larger size.
        Debug.LogFormat("num1 + (int)num2: {0}", num1 + (int)num2); // Not rounding

        Debug.LogFormat("num3: {0}", num3);
    }

    void Datatype_Default()
    {
        int num = new();        // Numeric types' default value is 0
        string text = null;     // String is reference type, default value is null
        bool boolean = new();   // Boolean types' default value is false

        Debug.LogFormat("num: {0}, text: {1}, boolean: {2}", num, text, boolean);
    }
}
