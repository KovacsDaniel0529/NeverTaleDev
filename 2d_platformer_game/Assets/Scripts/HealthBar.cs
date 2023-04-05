using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Sprite healthStage1, healthStage2, healthStage3, healthStage4;
    public Image healthBarIMG;
    private Animator anim;
    public static float totalHealth = 100f;
    public float tHP = totalHealth;



    private void Start()
    {
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
    }

    public void Heal(float heal)
    {
        if ((totalHealth ) < 100f)
        {
            totalHealth += heal;
        }
        else
        {
            totalHealth = 100f;
            
        }
        ChangeHealthBarStage();
        Debug.Log("Heal");
    }

    public void ChangeHealthBarStage()
    {
        if (totalHealth >= 100f)
        {
            healthBarIMG.sprite = healthStage1;
        }
        if (totalHealth <= 75f)
        {
            healthBarIMG.sprite = healthStage2;
        }
        if (totalHealth <= 50f)
        {
            healthBarIMG.sprite = healthStage3;
        }
        if (totalHealth <= 25f)
        {
            healthBarIMG.sprite = healthStage4;
        }
    }
    
}
