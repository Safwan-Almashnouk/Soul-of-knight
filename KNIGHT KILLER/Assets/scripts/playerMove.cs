using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerMove : MonoBehaviour
{

    [SerializeField] private float Walkspeed = 50f;
    [SerializeField] private float rotSpeed = 50f;
    [SerializeField] private float runSpeed = 80f;
    [SerializeField] private float DefaultSpeed = 50f;
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
        if (ani.GetCurrentAnimatorStateInfo(0).IsName("DodgeF"))
        {
            Debug.Log("DodgeF");
            DefaultSpeed = 0.0f;
            runSpeed= 0.0f;
            rotSpeed= 0.0f;
        }
        else
        {
            DefaultSpeed = 200f;
            rotSpeed = 200f;
            runSpeed= 300f;
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








