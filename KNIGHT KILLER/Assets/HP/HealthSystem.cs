using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public int Health = 100;
    
    public int attackPower;

    public HealthBar healthbar;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            takeDamage (20);
        }

    }

    public void takeDamage(int amount)
    {
        Health -= amount;
        
    }
    public void DealDamage(GameObject target)
    {
        var atm = target.GetComponent<HealthSystem>();
        if (atm != null)
        {
            atm.takeDamage(attackPower);
        }
    }
}
