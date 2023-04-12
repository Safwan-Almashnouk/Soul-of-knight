using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
    
{
    public HealthSystem PlayerHealth;
   
    public void Update ()
    {
       if (PlayerHealth.Health <= 0)
        {
            SceneManager.LoadScene("YouDied");
        }
       
    }
 
}
