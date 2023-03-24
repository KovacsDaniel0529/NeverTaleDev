using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public int enemyHP;
    private int currentHP;

    private Animator anim;
    private bool isDead;

    private Collider2D parentCol;
    private Collider2D hurtBoxCol;
    // Start is called before the first frame update
    void Start()
    {
        currentHP = enemyHP;
        anim = transform.parent.GetComponent<Animator>();
        parentCol = transform.parent.GetComponent<Collider2D>();
        hurtBoxCol = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHP <=0)
        {
            isDead = true;
            parentCol.enabled = false;
            hurtBoxCol.enabled = false;
            Die();
            StartCoroutine("KillSwitch");
            //Destroy(transform.parent.gameObject);
        }
    }
    public void TakeDamage(int damage)
    {
        currentHP -= damage;
    }
    IEnumerable KillSwitch()
    {
        yield return new WaitForSeconds(0.6f);
        Destroy(transform.parent.gameObject);
    }
    private void Die()
    {
        anim.SetBool("Dead", isDead);
        transform.parent.GetComponent<WayPontFollower>().enabled = false;
    }
}
