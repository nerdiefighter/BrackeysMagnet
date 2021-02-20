﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetScript : MonoBehaviour
{
    public PlayerBehavior player;
    public Vector3 move;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindObjectOfType<PlayerBehavior>();

        move.x = player.move.x;
        move.y = player.move.y;
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(move);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "wall")
        {
            player.Move();
            move.x = 0;
            move.y = 0;
        }
    }
}
