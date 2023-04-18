using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Enemy : MonoBehaviour
{
    public Transform player;
    Vector3 gap;

    public float speed;
    public float howClose;
    public float dist;
    private Animator ani;
    public HealthSystem EnemyHealth;
    private Rigidbody rb;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        ani = GetComponentInChildren<Animator>();
        rb = GetComponent<Rigidbody>(); 

    }

    // Update is called once per frame
    void Update()
    {
        gap = player.position - transform.position;
        
        dist = Vector3.Distance(player.position, transform.position);
        Vector3 direction = player.transform.position - transform.position;
        
        if (Vector3.Distance(transform.position, player.position) >= 0.5f)
        {
            //transform.rotation = Quaternion.LookRotation(transform.position + player.transform.position);
            transform.LookAt(player.transform.position);
            direction = player.transform.position- transform.position;
            transform.position += direction * speed * Time.deltaTime;

            ani.SetTrigger("Run");
            ani.ResetTrigger("Idle");
            
        }
        if (gap.x < 1.5f && gap.z < 1.5f)
        {
            ani.SetTrigger("Attack");
            ani.ResetTrigger("Run");
        }
        else
        {
            ani.SetTrigger("Idle");
            ani.ResetTrigger("Run");
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
