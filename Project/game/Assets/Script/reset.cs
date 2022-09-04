using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class reset : MonoBehaviour
{
    
    public Rigidbody rb;
    public float movespeed;
    public float jumpspeed;
    bool jumpPressed;
    //Collider col;
    public Transform[] respawnPoint;
    
    
    

    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = respawnPoint[0].position;
      
        rb = GetComponent<Rigidbody>();
        //col = GetComponent<Collider>();
 
    }

    // Update is called once per frame
    void Update()
    {
    float height = transform.position.y;

     float h = Input.GetAxis("Horizontal");
     float v = Input.GetAxis("Vertical");
     float distance = movespeed* Time.deltaTime;
     rb.velocity = new Vector3 (0,rb.velocity.y,0);
     Vector3 currentPosition = transform.position;
     Vector3 movement = (transform.forward * v + transform.right * h) * distance;
     rb.MovePosition(currentPosition + movement);
    jumpPressed = Input. GetButtonDown("Jump");
    
         if (jumpPressed)
         {
            // jumpPressed = true;
             Vector3 jumpVector= new Vector3(0.0f,jumpspeed,0.0f);
             rb.velocity += jumpVector;
             rb.AddForce(Vector3.up * 6.0f, ForceMode.Impulse);
         }
         if (height < 120.0f )
         {
             //Debug.Log("you die");
                 //transform.position = respawnPoint[0].position;
                 restart();
         }

    void restart()
     {
         Debug.Log("You Lose");
        SceneManager.LoadScene(1);
     }
     void win()
     {
         Debug.Log("You Win");
         SceneManager.LoadScene(2);
     }
     void OnTriggerEnter(Collider col)
     {
         if(col.tag == "Finish")
         {
             win();
         }
     }
            
         
    }
    
}
        
     
    

  
   
    
    
    

    

  