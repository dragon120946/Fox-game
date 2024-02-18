using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class HideTileCtrl : MonoBehaviour
{
    public TilemapCollider2D tilecol;
    public Tilemap tile;
    
    void Start()
    {
        tilecol.isTrigger = true;
        tile.color = new Color(1, 1, 1, 0);
    }
    
    void Update()
    {
        if (GameManager.score >= 15)
        {
            tilecol.isTrigger = false;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            tile.color = new Color(1, 1, 1, 1);
        }
    }
    
    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            tile.color = new Color(1, 1, 1, 0);
        }
    }
}
