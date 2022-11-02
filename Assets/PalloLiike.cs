using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalloLiike : MonoBehaviour
{
    [SerializeField]
    bool testimuuttuja1;

    [SerializeField]
    int testimuuttuja2;

    [SerializeField]
    float testimuuttuja3;

    [SerializeField]
    string testimuuttuja4;

    void Start()
    {
        
    }

    void Update()

    {

        if ( Input.GetKeyDown("y") )

            {
            if ( testimuuttuja4.Contains("nelli") == true )
                {
                Debug.Log("Nappi y painettu"); 

                Rigidbody fysiikka = GetComponent<Rigidbody>();

                fysiikka.AddForce( Vector3.up*1000f );
                }

            }

    }
}
