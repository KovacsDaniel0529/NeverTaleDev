using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsDamageByEnemy : MonoBehaviour
{
    public Rigidbody2D Player;
    public CharacterController2D characterController;
    public GameObject Knight;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Character")
        {
            if (Player.velocity.y >= 0)
            {
                int cooloffwait = 50;
                if (characterController.spikeDamaheCoolOff == 0)
                {
                    Health.totalHealth -= 25f;
                    characterController.spikeDamaheCoolOff = cooloffwait;
                }
                Debug.Log("The enemy hit the player");
            }

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Character")
        {
            if (Player.velocity.y < 0)
            {
                Debug.Log("Enemy is Dead");
                Destroy(Knight);
            }
        }
    }






}
