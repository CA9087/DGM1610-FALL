using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{   
    public float speed;
    public float turnSpeed;
    private Rigidbody eRb;
    private GameObject player;
    //public GameObject blaster;
    //public GameObject projectilePrefab;
    //private float startDelay = 3;
    //private float shootInterval = 2f;
    // Start is called before the first frame update
    void Start()
    {
        eRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
        //InvokeRepeating("ShootPlayer", startDelay, shootInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    
    }
    
    private void OnTriggerEnter (Collider other)
    {
        if (!gameObject.CompareTag("EnemyLaser"))
        {
        Destroy(gameObject);
        Destroy(other.gameObject);
        }
        Destroy(other.gameObject);
    }
    //private void ShootPlayer()
    

        
    
        //Instantiate(projectilePrefab, blaster.transform.position, transform.rotation);
        
    
}
