using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Weapon_Atb : MonoBehaviour
{
  public HealthSystem healthSystem;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<HealthSystem>().takeDamage(healthSystem.attackPower);
            Debug.Log("Hit");
        }
    }
}
