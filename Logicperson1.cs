using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logicperson1 : MonoBehaviour
{
    public float velMov=5.0f;  //linear speed 
    public float velRot = 200.0f; //rotational speed
    private Animator anim;
    //public Rigidbody rb;

    public float x, y;  // to know if person is moving
    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("Lets start");
        //rb.useGravity = true;
        //rb.AddForce(0, 200, 50);

        anim = GetComponent<Animator>();

        
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        //transform.Rotate(0, x*Time.deltaTime*velRot, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velMov);
        Debug.Log(y);
        if (Input.GetKey("d")) {
            Debug.Log("right boton");
            //rb.AddForce(500*Time.deltaTime, 0, 0); 
        }
        if (Input.GetKey("a"))
        {
            Debug.Log("left boton");
            //rb.AddForce(-500*Time.deltaTime, 0, 0); 
        }

    }
}
