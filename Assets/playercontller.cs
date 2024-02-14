using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += new Vector3(1, 0, 0)* Time.deltaTime;



        float x = Input.GetAxis("Horizontal");
        Debug.Log(x);

        Vector3 movement =  Vector3.right * x *  Time.deltaTime;

       

        float VerticalInput = Input.GetAxis("Vertical");

        movement += Vector3.forward * VerticalInput;

        movement = movement.normalized;



        movement *= Time.deltaTime;

        
     





        transform.position += movement;


    }
}
