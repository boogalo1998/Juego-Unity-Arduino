using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girador : MonoBehaviour
{

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void OnCollisionStay(Collision collision)
    {
       transform.Rotate(new Vector3(0f, 10f, 0f) * Time.deltaTime);
       
    }


}
