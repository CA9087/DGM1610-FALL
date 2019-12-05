using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float speed;
    private float turnSpeed = 120f;
    public float horSpeed; 
    public GameObject projectilePrefab;
    private Rigidbody pRB;
    public GameObject[] blasters;

    // Start is called before the first frame update
    void Start()
    {
        blasters = GameObject.FindGameObjectsWithTag("Them Guns");
        pRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (GameObject test in blasters)
            {
            Instantiate(projectilePrefab, test.transform.position, transform.rotation);
            }
        }
    }
    //makes the dude move
    void PlayerMovement()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        //this code makes the vehicle move
        transform.Translate(Vector3.forward *Time.deltaTime * speed * ver);    
        transform.Rotate(Vector3.up, turnSpeed * hor * Time.deltaTime * horSpeed);
    }

}
    