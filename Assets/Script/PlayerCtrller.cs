using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class PlayerCtrller : MonoBehaviour
{

    public Rigidbody2D rigidbody2D;
    public Animator animator;
    
    private bool isHurt;
    private bool isAir = false;

    public S1mgr mgr;

    void Start()
    {
       Debug.Log("My HP = " + GameManager.HP);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))  //玩家移動
        {
            rigidbody2D.velocity = new Vector2(-5, rigidbody2D.velocity.y);
            transform.localScale = new Vector3(-1, 1, 1);
            animator.SetBool("running",true);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody2D.velocity = new Vector2(5, rigidbody2D.velocity.y);
            transform.localScale = new Vector3(1, 1, 1);
            animator.SetBool("running",true);
        }
        else
        {
            animator.SetBool("running",false);
        }

        if (Input.GetKeyDown(KeyCode.Space) && isAir == false)  //跳躍
        {
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x,8);
            
            animator.SetBool("jumping",true);
        }
        else
        {
            animator.SetBool("jumping",false);
        }
    }

    void OnCollisionEnter2D(Collision2D col)    //扣血
    {
        isHurt = false;
        if (col.gameObject.CompareTag("Enemy"))
        {
            isHurt = true;
            GameManager.HP--;
        }

        if (isHurt)
        {
            rigidbody2D.velocity = new Vector2(-5, 5);
            animator.SetBool("hurting",true);
            isHurt = false;
        }
        else
        {
            animator.SetBool("hurting",false);
        }
    }

    void OnTriggerEnter2D(Collider2D other)     //得分
    {
        Debug.Log(other.name);
        if (other.gameObject.CompareTag("item"))
        {
            GameManager.isGetGem = true;
            Destroy(other.gameObject);
            
            mgr.ScoreUp();
        }
    }
}
