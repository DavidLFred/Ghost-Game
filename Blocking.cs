using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocking : MonoBehaviour
{
    [SerializeField] CentralM central;
    GameObject Soul;
    [SerializeField] float Range;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void BlockYou()
    {
        if(central.IsSoul)
        {
           float Fange = Vector2.Distance(transform.position, Soul.transform.position);
            Debug.Log(Fange);
            
        if(Fange <= Range)
        {

                central.GotLey = true;
                
                Destroy(GameObject.FindGameObjectWithTag("Door1"));
                Destroy(gameObject);      
                
        }
        
        else
            {
                central.GotLey =false;
            }

        }
        

    }
    

    
    



    void Find()
    {  
            Soul = GameObject.FindGameObjectWithTag("Soul");
    }
    // Update is called once per frame
    void Update()
    {




       
        Find();
        BlockYou();
        
    }
}
