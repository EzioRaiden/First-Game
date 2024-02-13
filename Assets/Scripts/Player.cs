using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //public Transform groundchecktransform;
    [SerializeField] private Transform groundchecktransform=null;
    private bool jumpkeywaspressed;
    private float horizontalinput;
    private Rigidbody rigidbodycomponent;
    [SerializeField]private LayerMask playerMask;
    public float jumppower;
    public float playerSpeed;

    //int superjumpsremainig=0;
    //private bool isgrounded;
    // Start is called before the first frame update
    void Start()
    {
        rigidbodycomponent = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            jumpkeywaspressed=true;
        }
        horizontalinput=Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        rigidbodycomponent.velocity= new Vector3(horizontalinput*playerSpeed, rigidbodycomponent.velocity.y, 0);
        // if(!isgrounded)
        // {
        //     return;
        // }
       if(Physics.OverlapSphere(groundchecktransform.position,0.1f,playerMask).Length==0)
       {
            return;
       }
        if(jumpkeywaspressed)
        {
            rigidbodycomponent.AddForce(Vector3.up*jumppower,ForceMode.VelocityChange);
            jumpkeywaspressed=false;
        }         
    }
    //private void OnCollisonEnter(Collison collison)
    // {
    //     isgrounded=true;
    // }
    // private void OnCollisonExit(Collison collison)
    // {
    //     isgrounded=false;
    // }
    
}
