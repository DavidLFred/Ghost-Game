using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

  
   
    
    [Header(" Movement")]
    [SerializeField] private float Speed;
    [SerializeField] private float MaxSpeed;
    [SerializeField] private bool FacingRight;
    public Rigidbody2D Rb;
    [SerializeField] Vector2 Direct;
    [SerializeField] private float LineDrag;
    


    void MovePlayer(float MoveMent)
    {
        Rb.AddForce(Vector2.right * MoveMent * Speed);

        if ((MoveMent > 0 && !FacingRight) || (MoveMent < 0 && FacingRight))
        {
            Flip();

        }

        if (Mathf.Abs(Rb.velocity.x) > MaxSpeed)
        {
            Rb.velocity = new Vector2(Mathf.Sign(Rb.velocity.x) * MaxSpeed, Rb.velocity.y);

        }

    }

    private void FixedUpdate()
    {
       
        ModifyPlayer();
        MovePlayer(Direct.x);

        
        
    }


    void ModifyPlayer()
    {
        bool ChangingDeirct = (Direct.x > 0 && Rb.velocity.x < 0) || (Direct.x < 0 && Rb.velocity.x < 0);
        if (Mathf.Abs(Direct.x) < 0.4f || ChangingDeirct)
        {
            Rb.drag = LineDrag;
        }

        else
        {
            Rb.drag = 0;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Direct = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
       
    }


    void Flip()
    {
        FacingRight = !FacingRight;
        transform.rotation = Quaternion.Euler(0, FacingRight ? 0 : 180, 0);
    }






}
