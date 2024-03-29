using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{
    public Vector3 respawnPoint;
    private Rigidbody2D rb;
    private Animator anim;

    public void RespawnNow()
    {
        rb.bodyType = RigidbodyType2D.Dynamic;
        transform.position = respawnPoint;
        anim.Play("Player_Idle");
        GetComponent<PlayerMovement>().enabled = true;
        Debug.Log("Respawn!!!");
        


    }
    public void RespawnOnDead()
    {
        
            if (HealthBar.totalHealth == 0f)
            {
                Die();
                
                HealthBar.totalHealth = 100f;
                Debug.Log("M�g mindig halott");
            }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Death")
        {
            FindObjectOfType<AudioManager>().Play("DedSound");
            HealthBar.totalHealth = 100f;
            Life.fullLife -= 1;
            Debug.Log(Life.fullLife);
            RespawnNow();
        }
        if (collision.gameObject.tag == "trap")
        {
            RespawnOnDead();
        }
        if (collision.gameObject.tag == "Enemy")
        {
            RespawnOnDead();
        }

    }
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        RespawnOnDead();
        
    }
    private void Die()
    {
        FindObjectOfType<AudioManager>().Play("BubbleDed");
        Life.fullLife -= 1;
        Debug.Log(Life.fullLife);
        anim.SetBool("IsJumping", false);
        GetComponent<PlayerMovement>().enabled = false;
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("Death");
        
        
    }
    
}
