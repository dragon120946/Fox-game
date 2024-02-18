using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class HideTileCtrl3 : MonoBehaviour
{
    public Tilemap tile;
    public bool canSee;
    
    void Start()
    {
        tile.color = new Color(1, 1, 1, 0);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player") && GameManager.score >= 29)
        {
            tile.color = new Color(1, 1, 1, 1);
            
            canSee = true;
        }
    }
}
