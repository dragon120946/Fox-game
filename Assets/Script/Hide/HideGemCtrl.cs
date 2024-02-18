using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideGemCtrl : MonoBehaviour
{
    public SpriteRenderer sprRend;
    public HideTileCtri2 hideTile;
    void Start()
    {
        GetComponent<SpriteRenderer>();
        sprRend.color = new Color(1, 1, 1, 0);
    }

    
    void Update()
    {
        if (GameManager.score >= 21 && hideTile.canSee)
        {
            sprRend.color = new Color(1, 1, 1, 1);
        }
    }
}
