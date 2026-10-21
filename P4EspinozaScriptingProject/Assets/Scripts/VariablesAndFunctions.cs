using System;using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using static UnityEngine.Networking.UnityWebRequest;

public class VariablesAndFunctions : MonoBehaviour
{
    // This is a variable
    int myInt = 36;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(myInt);
        myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);
    }


    // Update is called once per frame
    void Update()
    {

    }

    // This is a function
    int MultiplyByTwo(int number)
    {
        int result;
        result = number * 2;
        return result;




    }
}
