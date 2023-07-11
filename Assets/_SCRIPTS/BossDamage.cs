using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossDamage : MonoBehaviour
{
	public int damage = 15;
	public PlayerHealth playerHealth;
	public Animator anim;

	public void OnCollisionEnter2D(Collision2D collision2)
	{
		if (collision2.gameObject.tag == "Player")
		{
			
			playerHealth.TakeDamage(damage);
			anim.SetTrigger("attack");
		}
	}
}
