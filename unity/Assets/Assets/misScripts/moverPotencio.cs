using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class moverPotencio : MonoBehaviour
{
    public float vel;
    public float vel2;

    private int dir;
    private int dir2;

    SerialPort puerto = new SerialPort("COM5", 9600);

    // Start is called before the first frame update
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
                mover(puerto.ReadLine());
            }
            catch (System.Exception)
            {

            }
        }
    }
    void mover(string datoArduino)
    {
        string[] datosArray = datoArduino.Split(char.Parse(","));

        if (datosArray.Length == 2)
        {
            dir = int.Parse(datosArray[0]);
            dir2 = int.Parse(datosArray[1]);
            print(dir + " " + dir2);
        }

        if (dir >= 500)
        {
            transform.Translate(Vector3.right* vel, Camera.main.transform);
        }

        if (dir < 500)
        {
            transform.Translate(Vector3.right* vel, Camera.main.transform);
        }

        if (dir2 >= 500)
        {
            transform.Translate(Vector3.right* vel2, Camera.main.transform);
        }

        if (dir2 < 500)
        {
            transform.Translate(Vector3.left* vel, Camera.main.transform);
        }
    }
}
