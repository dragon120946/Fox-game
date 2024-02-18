using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleCtrl : MonoBehaviour
{
    #region 外部變數（物件）    //public
 
    public Transform up;
    public Transform down;
 
    #endregion
 
    #region 內部變數    //private
 
    private Rigidbody2D rb;
 
    private bool walkdown = true; //是否往下走

    public Animator animator;

    public GameObject player;
 
    #endregion
 
    #region unity function
 
    void Start()
    {
        this.transform.DetachChildren();
 
        rb = this.GetComponent<Rigidbody2D>(); //抓元件使用
    }
 
    void Update()
    {
        // 判斷
        if (down.localPosition.y > this.transform.localPosition.y)
        {
            //Debug.Log("超出下邊界!!");
            walkdown = false;
        }
        if (up.localPosition.y < this.transform.localPosition.y)
        {
            // Debug.Log("超出上邊界!!");
            walkdown = true;
        }
         
        //執行
        if (walkdown)
        {
            rb.velocity = new Vector2(rb.velocity.x, -3);
        }
        else
        {
            rb.velocity = new Vector2(rb.velocity.x, 3);
        }

        if (player.transform.position.x > transform.position.x)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else
        {
            transform.localScale = new Vector3(1, 1, 1); 
        }
    }
 
    #endregion
}
