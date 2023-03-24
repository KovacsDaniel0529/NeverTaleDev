using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stomper : MonoBehaviour
{

    public int damageToDeal;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = transform.parent.GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "HurtBox")
        {
            other.gameObject.GetComponent<EnemyHP>().TakeDamage(damageToDeal);
        }
    }
}
