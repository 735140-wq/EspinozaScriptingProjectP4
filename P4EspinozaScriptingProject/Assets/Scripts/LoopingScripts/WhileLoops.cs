using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WowLoops : MonoBehaviour
{
    // Creating a variable for my project
    int cupsInTheSink = 4;

    // Start is called before the first frame update
    void Start()
    {
        // My wow loop is going to check if there are cups in the sink, if yes they will be washed
        while (cupsInTheSink > 0)
        {
            Debug.Log("I'VE WASHED A CUP!");
            cupsInTheSink--;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
