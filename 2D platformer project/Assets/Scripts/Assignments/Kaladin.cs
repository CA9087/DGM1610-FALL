using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kaladin : MonoBehaviour
{
    string firstName = "Kaladin";
    int age = 20; 
    float height = 6.5f; 
    bool married = false; 

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("first Name: "+ firstName);   
        Debug.Log("Age: " + age);
        Debug.Log("Height: " + height);
        Debug.Log("married: " + married); 
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
