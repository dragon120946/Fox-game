using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtrlloler : MonoBehaviour
{
    #region 外部變數（物件）    //public
 
    public Transform left;
    public Transform right;
 
    #endregion
 
    #region 內部變數    //private
 
    private Rigidbody2D rb;
 
    private bool walkLeft = true; //是否往左走

    public Animator animator;
 
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
        if (left.localPosition.x > this.transform.localPosition.x)
        {
            //Debug.Log("超出左邊界!!");
            walkLeft = false;
        }
        if (right.localPosition.x < this.transform.localPosition.x)
        {
            // Debug.Log("超出右邊界!!");
            walkLeft = true;
        }
         
        //執行
        if (walkLeft)
        {
            rb.velocity = new Vector2(-3, rb.velocity.y);
            transform.localScale = new Vector3(1, 1, 1);
            //animator.SetBool("Jumping", true);
        }
        else
        {
            rb.velocity = new Vector2(3, rb.velocity.y);
            transform.localScale = new Vector3(-1, 1, 1);
            //animator.SetBool("Jumping", true);
        }
    }
 
    #endregion
}
