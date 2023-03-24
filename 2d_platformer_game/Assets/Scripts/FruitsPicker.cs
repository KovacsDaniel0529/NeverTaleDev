using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitsPicker : MonoBehaviour
{
	public HealthBar healthBar;

    private void Update()
    {
		healthBar.ChangeHealthBarStage();
	}
    public void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "melone")
		{
			healthBar.Heal(75f);
			Destroy(GameObject.FindWithTag("melone"));
		}
		else if (collision.tag == "banana")
		{
			healthBar.Heal(50f);
			Destroy(GameObject.FindWithTag("banana"));
		}
		else if (collision.tag == "apple")
		{
			healthBar.Heal(25f);
			Destroy(GameObject.FindWithTag("apple"));
		}
		else if (collision.tag == "cherry")
		{
			healthBar.Heal(25f);
			Destroy(GameObject.FindWithTag("cherry"));
		}


	}
}
