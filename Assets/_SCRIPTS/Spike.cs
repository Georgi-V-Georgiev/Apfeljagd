using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    private GameObject player;

    //OnTriggerStay -> to deal permanently damage
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            player.GetComponent<HeroKnight>().TakeDamage();
        }
    }

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

}
