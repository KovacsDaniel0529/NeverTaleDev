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
                    HealthBar.totalHealth -= 25f;
                    FindObjectOfType<AudioManager>().Play("HurtSound");
                    characterController.spikeDamaheCoolOff = cooloffwait;
                }
                Debug.Log("The enemy hit the player");
            }

        }
    }
    

    






}
