using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class appearTileCtrl : MonoBehaviour
{
    public TilemapCollider2D tilecol;
    public Tilemap tile;
    
    void Start()
    {
        tilecol.isTrigger = false;
        tile.color = new Color(1, 1, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.score >= 21)
        {
            tilecol.isTrigger = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            tile.color = new Color(1, 1, 1, 0);
        }
    }
}
