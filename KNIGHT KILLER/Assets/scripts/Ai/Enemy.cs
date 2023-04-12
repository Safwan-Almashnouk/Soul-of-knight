using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Enemy : MonoBehaviour
{
    public Transform player;
    private float dist;
    public float speed;
    public float howClose;
    private Animator ani;
    public HealthSystem EnemyHealth; 
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        ani = GetComponentInChildren<Animator>();
        ani = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(player.position, transform.position);

        if (dist <= howClose)
        {
            transform.rotation = Quaternion.LookRotation(transform.position + player.transform.position);
            GetComponent<Rigidbody>().AddForce(transform.forward * -speed);
            ani.SetTrigger("Run");
            ani.ResetTrigger("Idle");
        }
        if (dist <=2.5f)
        {
            ani.SetTrigger("Attack");
            ani.ResetTrigger("Run");
        }
        else
        {
            ani.SetTrigger("Idle");
        }
        if (EnemyHealth.Health <= 0)
        {
            ani.ResetTrigger("Idle");
            ani.ResetTrigger("Attack");
            ani.ResetTrigger("Run");
            ani.SetTrigger("death");

        }
    }
}
