using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{

    public GameObject NewTarget;
    [SerializeField] CentralM central;
    [SerializeField] CameraPaw Paw;
    
   
   
    
    
    // Start is called before the first frame update
    void Start()
    {
       central.IsSoul = GameObject.FindGameObjectWithTag("Soul"); 

    }
   
   
    // Update is called once per frame
    void Update()
    {
        Sommon();
       DisableMovr(central.Dead);
       

    }


    void DisableMovr(bool Red)
    {

        if (Red && central.attemps >= 0)
        {
           central.Player.GetComponent<Movement>().enabled = false;
            central.Player.GetComponent<Jumping>().enabled = false;
        }

        else

        {
            central.Player.GetComponent<Movement>().enabled = true;
            central.Player.GetComponent<Jumping>().enabled = true;

        }

    }
   
    void Sommon()
    {

        if(!central.IsSoul && central.Dead && central.attemps > 0)
        {
           
            Instantiate(central.SoulForm, central.Player.transform);
            central.IsSoul = true;
            --central.attemps;

         



        }

       

    }

}
