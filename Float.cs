using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Float : MonoBehaviour
{
    [SerializeField] private float Speed;
    [SerializeField] private Rigidbody2D Rb;
    [SerializeField] private Vector2 MoveVelocity;
    [SerializeField] private bool FacingRight;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 InPut = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        MoveVelocity = InPut.normalized * Speed;
        ModePlayer();
    }
    private void FixedUpdate()
    {
        Rb.MovePosition(Rb.position + MoveVelocity * Time.fixedDeltaTime);   


    }

    void ModePlayer()
    {
       if(MoveVelocity.x > 0 && !FacingRight|| MoveVelocity.x < 0 && FacingRight )
        {
            Flip();
        }    


    }

    void Flip()
    {

        FacingRight = !FacingRight;
        transform.rotation = Quaternion.Euler(0, FacingRight ? 0 : 180, 0);


    }


}
