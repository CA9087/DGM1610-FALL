using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float speed;
    private float turnSpeed = 60f; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        //this code makes the vehicle move
        transform.Translate(Vector3.forward*Time.deltaTime * speed * ver);    
        transform.Rotate(Vector3.up, turnSpeed * hor * Time.deltaTime);
    }
}
    