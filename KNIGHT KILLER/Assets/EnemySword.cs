using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class EnemySword : MonoBehaviour
{
    public HealthSystem healthSystem;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<HealthSystem>().takeDamage(healthSystem.attackPower);
            Debug.Log("Hit");
        }
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("Sowwy");
        }
    }
}