using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapDamage : MonoBehaviour
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
        if (collision.tag == "Character")
        {
            
            int cooloffwait = 25;
            if (characterController.spikeDamaheCoolOff == 0)
            {
                Debug.Log("traphit");
                Health.totalHealth -= 25f;
                characterController.spikeDamaheCoolOff = cooloffwait;
            }
        }
    }
}
