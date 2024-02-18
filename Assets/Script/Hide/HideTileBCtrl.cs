using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class HideTileBCtrl : MonoBehaviour
{
    public Tilemap tile;
    public TilemapCollider2D tilecol;
    void Start()
    {
        tilecol.isTrigger = true;
        tile.color = new Color(1, 1, 1, 0);
    }
}
