using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 100;
    public float currentHealth;
    public HeroKnight Player;

    void Start()
    {
        currentHealth = maxHealth;
    }


    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Player.TakeDamageAnimation();
        Debug.Log("You are hit");

        if (currentHealth <= 0)
        {
            //Die Animation
            Player.DieAnimation();
            //Game over screen?
        }
    }
}