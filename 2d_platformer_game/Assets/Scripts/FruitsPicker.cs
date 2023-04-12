using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitsPicker : MonoBehaviour
{
	public float healpoint;
	public HealthBar healthBar;

    private void Update()
    {
		healthBar.ChangeHealthBarStage();
		
	}
    public void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "FruitPicker")
		{
			healthBar.Heal(healpoint);
			Destroy(gameObject);
		}
		


	}
}
