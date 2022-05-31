using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CentralM : MonoBehaviour
{
    public bool WIn;
    public bool GotLey = false;
    public int attemps = 3;
    public GameObject Player;
    public GameObject SoulForm;
    public bool Dead = false;
    public bool IsSoul = false;
    public bool OnCircle = false;
    public Text YWIn;


    private void Update()
    {
        Win(WIn);

        attm();

    }
     
    void Win(bool win)
    {

        if(win)
        {
            YWIn.text = "You Win";

            if(attemps < 0 )
            {
                YWIn.text = "You lose";
            }

        }

    }

    void attm()
    {
        switch (attemps)
        {
            case 2:
                Destroy(GameObject.FindGameObjectWithTag("P3"));
                break;

            case 1:
                Destroy(GameObject.FindGameObjectWithTag("P2"));
                break;
            case 0:
                Destroy(GameObject.FindGameObjectWithTag("P1"));
                break;

        }

    }

    
}
