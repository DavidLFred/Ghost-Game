using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPaw : MonoBehaviour
{
    [Header("Components")]  
    [SerializeField] private Vector3 OffSet;
    [SerializeField] private Transform Target;
    [SerializeField] public Transform SecondTarget;
    [SerializeField] CentralM central;
    
   
    // Start is called before the first frame update
    void Start()
    {
        Target = central.Player.transform;
        
      



    }


    private void FixedUpdate()
    {
        

        Follow();
    }
    // Update is called once per frame
    void Update()
    {


        Find();

    }
   
    void Find()
    {
        while (SecondTarget == null)

        {
            SecondTarget = GameObject.FindGameObjectWithTag("Soul").transform;
        }

    } 
  
    


    void Follow()
    {
        if(!central.IsSoul)
        {
            transform.position = Target.position + OffSet;
        }

            
       else
        {
            transform.position = SecondTarget.position + OffSet;
            
        }

    }
}
