﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowX : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 3, -6);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Offset the camera behindthe player by adding to the player's position
        transform.position = player.transform.position + offset;    
    }
}