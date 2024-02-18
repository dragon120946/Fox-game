using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class LevelTileCtrl : TilemapCtrl
{
    public TilemapCollider2D tileCol;
    void Start()
    {
        tileCol.isTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.score == 10)
        {
            tileCol.isTrigger = true;
        }
    }
}
