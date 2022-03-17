using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{

    protected float speed = 1f;
    protected float jumpforce = 10f;

    private string m_AnimalName;

    protected Rigidbody animalRB;

    protected string AnimalName 
    {
        get { return name; }   // get method
        set { name = value; }  // set method
    }

    // Start is called before the first frame update
    void Start()
    {
        animalRB = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {

        //if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space key was pressed.");
        }


        Walk();
        if (Input.GetKey ( KeyCode.Space)) {
            Jump();
        } else if (Input.GetKey ( KeyCode.J)) {
            Jump(10);
        };
    }


    void Walk()    
    {
         //Debug.Log("Walk");
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //transform.position += Vector3.left * speed * Time.deltaTime;
            animalRB.AddForce(Vector3.left * speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            animalRB.AddForce(Vector3.right * speed);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {            
            animalRB.AddForce(Vector3.forward * speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            animalRB.AddForce(Vector3.back * speed);
        }
    }
    
    void Jump()
    {        
        animalRB.AddForce(Vector3.up * jumpforce);
        
    }

    void Jump(float extraPower)
    {
        animalRB.AddForce(Vector3.up * jumpforce * extraPower);        
    }

}
