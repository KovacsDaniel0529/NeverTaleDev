using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHitByArrow : MonoBehaviour
{
    public CharacterController2D characterController;
    private BoxCollider2D boxcollider;
    public HealthBar healthBar;


    // Start is called before the first frame update
    void Start()
    {
        boxcollider = GetComponent<BoxCollider2D>();

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "arrow")
        {

            int cooloffwait = 50;
            if (characterController.spikeDamaheCoolOff == 0)
            {
                Debug.Log("Hit the arrow");
                HealthBar.totalHealth -= 25f;
                FindObjectOfType<AudioManager>().Play("HurtSound");
                characterController.spikeDamaheCoolOff = cooloffwait;
            }
        }
    }
}
