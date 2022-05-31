using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondKey : MonoBehaviour
{


    [SerializeField] CentralM central;
    GameObject Player;
    [SerializeField] float Range;
   
    // Start is called before the first frame update
    void Start()
    {
        Player = central.Player;
    }

    void BlockYou()
    {
        if (!central.IsSoul)
        {
            float Fange = Vector2.Distance(transform.position, Player.transform.position);
            

            if (Fange <= Range)
            {
                central.WIn = true;
                central.GotLey = true;

                Destroy(GameObject.FindGameObjectWithTag("Door2"));
                Destroy(gameObject);

            }

            else
            {
                central.GotLey = false;
            }

        }


    }







    
    // Update is called once per frame
    void Update()
    {





       
        BlockYou();




    }

}