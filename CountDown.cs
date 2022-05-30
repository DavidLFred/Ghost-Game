using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CountDown : MonoBehaviour
{[SerializeField] CentralM central;
    public float Timeer = 60;
    public Text TextBox;
     
    // Start is called before the first frame update
    void Start()
    {
        TextBox.text = Timeer.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Timeer > 0 && central.Dead == true)
        {
        Timeer -= (Time.deltaTime);
        TextBox.text = Mathf.Round(Timeer).ToString();

        }

        if (Timeer < 0 && central.Dead == true && central.IsSoul == true)
        {
            central.Dead = false;
            central.IsSoul = false;
            Timeer = 10;
            Destroy(GameObject.FindGameObjectWithTag("Soul"));

        }
        


    }
}
