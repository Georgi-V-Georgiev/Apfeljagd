using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healing : MonoBehaviour
{
	public int healPoints = 10;
	public PlayerHealth playerHealth;

	public void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Player")
		{
			playerHealth.HealDamage(healPoints);
			Debug.Log("You ate an apple!");
			Destroy(gameObject);
		}
	}
}
