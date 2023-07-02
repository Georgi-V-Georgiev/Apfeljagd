using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    private GameObject player;
    private int damage = 5;

    //OnTriggerStay -> to deal permanently damage
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            player.GetComponent<HeroKnight>().TakeDamage();
            player.GetComponent<PlayerHealth>().TakeDamage(damage);
        }
    }

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

}
