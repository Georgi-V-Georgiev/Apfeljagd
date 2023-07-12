using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            StartCoroutine(Die());
        }
    }

    private IEnumerator Die()
    {
        // m_animator.SetBool("noBlood", m_noBlood);
        // m_animator.SetTrigger("Death");

        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void HealDamage(int healpoints)
    {
        currentHealth += currentHealth + healpoints;

        if (currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
        }
    }
}