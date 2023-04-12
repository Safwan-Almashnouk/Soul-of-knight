using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerMove : MonoBehaviour
{

    [SerializeField] private float Walkspeed = 200f;
    [SerializeField] private float rotSpeed = 200f;
    [SerializeField] private float runSpeed = 800f;
    [SerializeField] private float DefaultSpeed = 200f;
    private Rigidbody rb;
    public Animator ani;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    void Update()
    {
        AnimatorStateInfo clips = ani.GetCurrentAnimatorStateInfo(0);
        if (ani.GetCurrentAnimatorStateInfo(0).IsName("DodgeF") || ani.GetCurrentAnimatorStateInfo(0).IsName("Slash1") || ani.GetCurrentAnimatorStateInfo(0).IsName("Slash2") || ani.GetCurrentAnimatorStateInfo(0).IsName("Slash3"))
        {
          ;
            DefaultSpeed = 0.0f;
            runSpeed= 0.0f;
            rotSpeed= 0.0f;
        }
        else
        {
            DefaultSpeed = 200f;
            rotSpeed = 200f;
            runSpeed= 800f;
        }

        float move = Time.deltaTime * Walkspeed * Input.GetAxis("Vertical");

        float rot = Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        rb.transform.Rotate(new Vector3(0, rot, 0));
        Vector3 lastVel = rb.velocity;
        Vector3 newVel = rb.transform.forward * move;
        newVel.y = lastVel.y;
        rb.velocity = newVel;
        if (Input.GetKey(KeyCode.LeftShift) && (Input.GetAxis("Vertical") > 0))
        {
            Walkspeed = runSpeed;
        }
        else
        {
            Walkspeed = DefaultSpeed;
        }
    }
}








