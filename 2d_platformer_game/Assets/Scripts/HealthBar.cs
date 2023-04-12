using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Sprite healthStage1, healthStage2, healthStage3, healthStage4;
    public Image healthBarIMG;
    private Animator anim;
    public static float totalHealth;
    public float tHP = totalHealth;

    private void Update()
    {
        Debug.Log(totalHealth);
    }

    private void Start()
    {
        if (PlayerPrefs.GetFloat("hasHP") > 0f)
        {
            totalHealth = PlayerPrefs.GetFloat("hasHP");
        }
        else
        {
            totalHealth = 100f;
        }

        anim = GetComponent<Animator>();
        healthBarIMG = GetComponent<Image>();
        ChangeHealthBarStage();
        Debug.Log(totalHealth);
    }

    public void Damage(float damage)
    {

        if ((totalHealth -= damage) > 0f)
        {
            anim.SetTrigger("Hurt");

        }
        else
        {
            totalHealth = 0f;

        }
        ChangeHealthBarStage();
        Debug.Log("Damage");
        FindObjectOfType<AudioManager>().Play("HurtSound");
    }

    public void Heal(float heal)
    {
        if ((heal + totalHealth) >= 100f)
        {
            totalHealth = 100f;
        }
        else
        {
            totalHealth += heal;
            
        }
        ChangeHealthBarStage();
        Debug.Log("Heal");
        FindObjectOfType<AudioManager>().Play("HealSound");
    }

    public void ChangeHealthBarStage()
    {
        if (totalHealth == 100f)
        {
            healthBarIMG.sprite = healthStage1;
        }
        if (totalHealth == 75f)
        {
            healthBarIMG.sprite = healthStage2;
        }
        if (totalHealth == 50f)
        {
            healthBarIMG.sprite = healthStage3;
        }
        if (totalHealth == 25f)
        {
            healthBarIMG.sprite = healthStage4;
        }
    }
    
}
