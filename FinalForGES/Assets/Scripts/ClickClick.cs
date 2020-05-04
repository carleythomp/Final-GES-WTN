using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickClick : MonoBehaviour
{
    
    PlayRanSound soundPlayed;

    private void Start()
    {
       GameObject player = GameObject.FindGameObjectWithTag("Player");
        soundPlayed = player.GetComponent<PlayRanSound>();
    }

    void Update()
    {
        if( Input.GetMouseButtonDown(0))
        {
           Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
           RaycastHit rhit;

          if (Physics.Raycast(ray, out rhit))
          {
             if (rhit.transform.name == "toaster" && soundPlayed.flip == 0) 
             {          
               Debug.Log("Toaster");
             }
             if(rhit.transform.name == "teapot" && soundPlayed.flip == 2)
             {
                Debug.Log("Kettle");
                        
             }
             if(rhit.transform.name == "microwave" && soundPlayed.flip == 1)
             {
                Debug.Log("Microwave");
             }
          }
        }
       
    }
  
   
}
