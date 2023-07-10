using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    Rigidbody2D rb;
    Transform target;
    Vector2 moveDirection;
    public Animator anim;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        target = GameObject.Find("HeroKnight_Yellow").transform;
    }
    void Update()
    {
        if(target)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            //rb.rotation = angle;
            moveDirection = direction;
            anim.SetTrigger("run");    

        }
    }
    void FixedUpdate()
    {
        if(target)
        {
            rb.velocity = new Vector2(moveDirection.x, moveDirection.y) * speed;
        }
    }


}
