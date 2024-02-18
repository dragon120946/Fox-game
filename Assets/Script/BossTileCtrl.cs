using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BossTileCtrl : MonoBehaviour
{
    public Tilemap hTillB;
    public TilemapCollider2D hTillBcol;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player") && GameManager.score >= 29)
        {
            hTillB.color = new Color(1, 1, 1, 1);
            hTillBcol.isTrigger = false;
        }
    }
}
