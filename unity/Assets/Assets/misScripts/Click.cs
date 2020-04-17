using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    private GameObject CaerBola;

     public void OnMouseDown()
    {
        CaerBola = GameObject.Find("RollerBall");

        CaerBola.GetComponent<Rigidbody>().useGravity = true;
    }
}
