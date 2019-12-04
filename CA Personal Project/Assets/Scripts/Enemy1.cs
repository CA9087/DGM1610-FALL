using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{   
    public float speed;
    public float turnSpeed;
    private Rigidbody eRb;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        eRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter (Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
