using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class MoverArduino : MonoBehaviour
{
    SerialPort puerto = new SerialPort("COM5", 9600);

    public float distanciaMov;
    public float distanciaMov2;
    void Start()
    {
        puerto.Open();
        puerto.ReadTimeout = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (puerto.IsOpen)
        {
            try
            {
                mover(puerto.ReadByte());
            }
            catch (System.Exception)
            {

            }
        }
    }
    void mover (int direccion)
    {
        if(direccion == 1)
        {
            transform.Translate(Vector3.up * distanciaMov, Space.World);
        }

        if (direccion == 2)
        {
            transform.Translate(Vector3.left * distanciaMov2,Camera.main.transform);
        }

    }
}
