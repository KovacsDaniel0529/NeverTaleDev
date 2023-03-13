using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapDamage : MonoBehaviour
{
    public CharacterController2D characterController;
    private BoxCollider2D boxcollider;


    // Start is called before the first frame update
    void Start()
    {
        boxcollider = GetComponent<BoxCollider2D>();
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Character")
        {
            Debug.Log("traphit");
            int cooloffwait = 50;
            if (characterController.spikeDamaheCoolOff == 0)
            {
                Health.totalHealth -= 25f;
                characterController.spikeDamaheCoolOff = cooloffwait;
            }
        }
    }
}
