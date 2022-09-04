using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class traps : MonoBehaviour
{
    bool _goingDown = false;
    bool _stationary = true;
    float maxheight;
    Rigidbody _rb;
    Collider col;
    Vector3 _delta;
    public float minheight = 0.0f;
    public float speed = 1.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        maxheight = transform. position. y;
        _stationary = true;
        _goingDown = false;
        _rb = GetComponent<Rigidbody>();
    col = GetComponent<Collider>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_goingDown)
        {
           if(!_stationary)
        {
        _delta = new Vector3 (0.0f,speed*-1.0f,0.0f);
        }
        else
        {
            _delta = Vector3.zero;
            _goingDown = false;
            _stationary = true;
        }
        
        }
        
        
    }
    void OnTriggerEnter(Collider col)
    {
        
        if(col.tag == "Player")
        {
            
            _stationary = false;
        }
    }
    
}
