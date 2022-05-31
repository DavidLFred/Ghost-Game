using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RitualCircle : MonoBehaviour
{
    [Header("Compontes")]
    
    [SerializeField] CentralM Central;
   
   
    
     

    // Start is called before the first frame update
    void Start()
    {
        Central.Player = GameObject.FindGameObjectWithTag("Player");
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Central.OnCircle = true;
             
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Central.OnCircle = false;
       
        
    }

    void Deading()
    {
        if(Input.GetKeyDown(KeyCode.F) && Central.OnCircle == true && Central.attemps > 0)
        {
            Central.Dead = true;

        }

    }


    // Update is called once per frame
    void Update()
    {

        Deading();

     
    }
}
