using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserForward : MonoBehaviour
{
    public float speed = 40;
    public float outOfBounds = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   //move laser forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        //destroy laser that travel too far
        if (transform.position.x > outOfBounds || transform.position.x < -outOfBounds || transform.position.z > outOfBounds || transform.position.z < -outOfBounds)
        {
            Destroy(gameObject);
        }
        
    }
    private void OnTriggerEnter()
    {
        Destroy(this.gameObject);
    }
}
