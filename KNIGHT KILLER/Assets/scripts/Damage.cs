using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public HealthSystem playerAtm;
    public HealthSystem enemyAtm;
    public bool Hit;


    private void Update()
    {
       if(Hit == true)
        {
           playerAtm.DealDamage(enemyAtm.gameObject);
        }

    }

}
