using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;


public class Jump : MonoBehaviour

{
    Rigidbody m_Rigidbody;

    public float force = 20f;
    public bool allowJump = true;
    public Animator ani;

    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && allowJump == true)
        {
            //Apply a force to this Rigidbody in direction of this GameObjects up axis
            m_Rigidbody.AddForce(transform.up * force);

        }
        AnimatorStateInfo clips = ani.GetCurrentAnimatorStateInfo(0);
        if (ani.GetCurrentAnimatorStateInfo(0).IsName("DodgeF"))
        {
            Debug.Log("DodgeF");
            force = 0.0f;
        }
        else
        {
            force = 200f;
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "floor")
        {
            allowJump = true;
        }
    }
    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "floor")
        {
            allowJump = false;
        }
    }
}