using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickClick : MonoBehaviour
{
    
    PlayRanSound soundPlayed;
    ScoreManage trackingScore;
    private void Start()
    {
       GameObject player = GameObject.FindGameObjectWithTag("Player");
        soundPlayed = player.GetComponent<PlayRanSound>();
        trackingScore = player.GetComponent<ScoreManage>();
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
                    trackingScore.AddScore();
               Debug.Log("Toaster");
             }
             if(rhit.transform.name == "teapot" && soundPlayed.flip == 2)
             {
                    trackingScore.AddScore();
                Debug.Log("Kettle");
                        
             }
             if(rhit.transform.name == "microwave" && soundPlayed.flip == 1)
             {
                    trackingScore.AddScore();
                Debug.Log("Microwave");
             }
          }
        }
       
    }
  
   
}
