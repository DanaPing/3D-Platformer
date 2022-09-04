using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public Transform[] turnAround;
    public float moveSpeed;
    private int currentpoint; 

    // Start is called before the first frame update
    void Start()
    {
        transform.position = turnAround[0].position;
        currentpoint = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position == turnAround[currentpoint].position)
        {
            currentpoint++;
        }
        if(currentpoint >= turnAround.Length)
        {
            currentpoint = 0;
        }
        transform.position = Vector3.MoveTowards(transform.position, turnAround[currentpoint].position,moveSpeed*Time.deltaTime);
    }

    
}
