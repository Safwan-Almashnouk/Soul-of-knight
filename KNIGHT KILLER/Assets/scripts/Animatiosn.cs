using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Animatiosn : MonoBehaviour
{
    private Animator ani;
    

    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift) && (Input.GetAxis("Vertical") > 0))
        {
            //is de waarde groter dan 0 dan heb je een knop naar boven ingedrukt 
            //Roep de juiste trigger aan!
            ani.SetTrigger("Run");
            //SetTrigger is trigger activeren
            ani.ResetTrigger("Idle");
            ani.ResetTrigger("WalkR");
            ani.ResetTrigger("Walk");
            //ResetTrigger is Trigger de-activeren
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            //is de waarde kleiner dan 0 dan heb je een knop naar beneden ingedrukt
            //Roep de juiste trigger aan
            ani.SetTrigger("WalkR");
            ani.ResetTrigger("Idle");
            ani.ResetTrigger("Walk");
            ani.ResetTrigger("DodgeF");
        }
        else if (Input.GetAxis("Vertical") > 0)
        {
            ani.SetTrigger("Walk");
            ani.ResetTrigger("Run");
            ani.ResetTrigger("WalkR");
            ani.ResetTrigger("DodgeF");
        }

        else
        {
            //is de waarde 0 dan heb je niets ingedrukt
            //Roep de juiste trigger aan
            ani.SetTrigger("Idle");
            ani.ResetTrigger("Walk");
            ani.ResetTrigger("WalkR");
            ani.ResetTrigger("DodgeF");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ani.ResetTrigger("Idle");
            ani.ResetTrigger("Walk");
            ani.ResetTrigger("WalkR");
            ani.SetTrigger("Jump");
            ani.ResetTrigger("DodgeF");

        }
        if (Input.GetKeyDown(KeyCode.LeftControl) && (Input.GetAxis("Vertical") > 0))
        {
            ani.ResetTrigger("Idle");
            ani.ResetTrigger("Walk");
            ani.ResetTrigger("WalkR");
            ani.ResetTrigger("Jump");
            ani.SetTrigger("DodgeF");
            
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            ani.SetTrigger("Slash1");
            ani.ResetTrigger("Idle");
            ani.ResetTrigger("Walk");
            ani.ResetTrigger("WalkR");
            ani.ResetTrigger("Jump");
            ani.ResetTrigger("DodgeF");
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            ani.SetTrigger("Slash2");
            ani.ResetTrigger("Idle");
            ani.ResetTrigger("Walk");
            ani.ResetTrigger("WalkR");
            ani.ResetTrigger("Jump");
            ani.ResetTrigger("DodgeF");
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            ani.SetTrigger("Slash3");
            ani.ResetTrigger("Idle");
            ani.ResetTrigger("Walk");
            ani.ResetTrigger("WalkR");
            ani.ResetTrigger("Jump");
            ani.ResetTrigger("DodgeF");
        }
    }
}
