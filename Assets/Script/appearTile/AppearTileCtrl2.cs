using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class AppearTileCtrl2 : MonoBehaviour
{
    public TilemapCollider2D tilecol;
    public Tilemap tile;
    
    void Start()
    {
        tilecol.isTrigger = false;
        tile.color = new Color(1, 1, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.score >= 21)
        {
            tilecol.isTrigger = false;
            tile.color = new Color(1, 1, 1, 1);
        }
        
        if (GameManager.score >= 29)
        {
            tilecol.isTrigger = true;
            tile.color = new Color(1, 1, 1, 0);
        }
    }
}
