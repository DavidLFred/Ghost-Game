using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : MonoBehaviour
{
    [Header("Jumping")]
    [SerializeField] private float JumpForce;
    [SerializeField] private float JumpDely;
    [SerializeField] private float JumpTimer;
    [Header("collisions")]
    public LayerMask Ground;
    [SerializeField] private bool OnGround = false;
    [SerializeField] private float RayLength;
    [SerializeField] private float Offset;
    [SerializeField] private Vector3 ColliderOffSet;
    //[SerializeField] private Rigidbody2D Rb;
    public Movement movement;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    void Jump()
    {
        movement.Rb.velocity = new Vector2(movement.Rb.velocity.x, 0);
        movement.Rb.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);

    }
    // Update is called once per frame
    void Update()
    {
        OnGround = Physics2D.Raycast(transform.position + ColliderOffSet, Vector2.down, RayLength, Ground) || Physics2D.Raycast(transform.position - ColliderOffSet, Vector2.down, RayLength, Ground);
        if (Input.GetButtonDown("Jump") && OnGround)
        {
            Jump();
        }

        //OnDrawGizmos();
        


       
        
           
        

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position + ColliderOffSet, transform.position + ColliderOffSet + Vector3.down * RayLength);
        Gizmos.DrawLine(transform.position - ColliderOffSet, transform.position - ColliderOffSet + Vector3.down * RayLength);

    }


}
