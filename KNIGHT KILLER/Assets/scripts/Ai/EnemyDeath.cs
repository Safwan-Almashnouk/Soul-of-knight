using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public HealthSystem EnemyHealth;
    public GameObject enemy;
    public Animator animator;
    public GameObject hitbox;
    private bool isDead = false;
    private Animator ani;
    // Update is called once per frame
    void Update()
    {
        if (EnemyHealth.Health <= 0 && !isDead)
        {
            isDead = true;
            StartCoroutine(FuckingDie());
        }
        else
        {
            return;
        }
    }

    private IEnumerator FuckingDie()
    {
        yield return new WaitForSeconds(1.5f);
        Destroy(enemy);
        Destroy(animator);
        Destroy(hitbox);
        
    }
}
