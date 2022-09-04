using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class time : MonoBehaviour
{
    public Text statusText;
    float timecount = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timecount -= Time.deltaTime;
        statusText.text = "Time" + "  "+ (int)timecount; 
        if(timecount < 0)
        {
            restart();
        }
    }
    void restart()
     {
         Debug.Log("You Lose");
        SceneManager.LoadScene(1);
     }
    
}
