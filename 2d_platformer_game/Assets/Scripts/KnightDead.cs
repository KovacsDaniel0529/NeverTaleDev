using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightDead : MonoBehaviour
{
    public Rigidbody2D Player;
    public GameObject Knight;
    public BoxCollider2D Collider;
    private Animator anim;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Character")
        {
            if (Player.velocity.y < 0)
            {
                
                anim.SetTrigger("IsDead");
                Destroy(transform.parent.gameObject);
                Debug.Log("Enemy is Dead");

            }

        }
    }
    /*public void KnightDeath()
    {
        if (!IsDead)
        {
            Death();
        }
    }*/
    private void Start()
    {
        anim =  transform.parent.GetComponent<Animator>();
    }
    /*private void Die()
    {
        anim.SetBool("IsDead", true);
    }*/
    /*private void Update()
    {
        KnightDeath();
       
    }*/
    /*public void Death()
    {
        Destroy(Knight);
    }*/





}
