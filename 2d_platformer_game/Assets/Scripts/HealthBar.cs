using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Sprite healthStage1, healthStage2, healthStage3, healthStage4;
    public Image healthBarIMG;
    private Animator anim;

       
    
    private void Start()
    {
        anim = GetComponent<Animator>();
        healthBarIMG = GetComponent<Image>();
        ChangeHealthBarStage();
        Debug.Log(Health.totalHealth);
    }

    public void Damage(float damage)
    {

        if ((Health.totalHealth -= damage) > 0f)
        {
            
            anim.SetTrigger("Hurt");
            
        }
        else
        {
            Health.totalHealth = 0f;

        }
        ChangeHealthBarStage();
        Debug.Log("Damage");
    }

    public void Heal(float heal)
    {
        if ((Health.totalHealth ) < 100f)
        {
            Health.totalHealth += heal;
        }
        else
        {
            Health.totalHealth = 100f;
            
        }
        ChangeHealthBarStage();
        Debug.Log("Heal");
    }

    public void ChangeHealthBarStage()
    {
        if (Health.totalHealth >= 100f)
        {
            healthBarIMG.sprite = healthStage1;
        }
        if (Health.totalHealth <= 75f)
        {
            healthBarIMG.sprite = healthStage2;
        }
        if (Health.totalHealth <= 50f)
        {
            healthBarIMG.sprite = healthStage3;
        }
        if (Health.totalHealth <= 25f)
        {
            healthBarIMG.sprite = healthStage4;
        }
    }
    
}
