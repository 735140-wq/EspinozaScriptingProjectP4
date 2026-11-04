using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifStatements : MonoBehaviour
{
    //Creating the variables for my script


    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;

    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
            TemperatureTest();
            coffeeTemperature -= Time.deltaTime * 5f;
    }
    void TemperatureTest()
    {
        // If the coffee's temperature is greater than the hottest drinking temperature...
        if (coffeeTemperature > hotLimitTemperature)
        {
            // ... do this.
            Debug.Log("Coffee is too hot.");
        }
        // if it isnt but the coffee temp is less than the cold
        else if (coffeeTemperature < coldLimitTemperature)
        {
            // ... do this.
            Debug.Log("Coffee is too cold.");
        }
        // if its neither...
        else
        {
            // ... do this.
            Debug.Log("Coffe is just right");
             
        }
    }
}
