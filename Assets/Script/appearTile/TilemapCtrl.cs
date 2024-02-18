using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TilemapCtrl : MonoBehaviour
{
    public Tilemap tilemap;
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            tilemap.color = new Color(1, 1, 1, 0.5f);
        }
    }
    
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            tilemap.color = new Color(1, 1, 1, 1f);
        }
    }
}
