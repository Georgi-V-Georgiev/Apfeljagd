using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnCollision : MonoBehaviour
{
	public int damage = 10;
	public PlayerHealth playerHealth;
	public void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Player")
		{
			playerHealth.TakeDamage(damage);
		}
	}
}
