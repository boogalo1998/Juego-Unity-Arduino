using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevador : MonoBehaviour
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
        transform.Translate(Vector3.up * Time.deltaTime);
    }


}
