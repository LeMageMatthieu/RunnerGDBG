using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterController : MonoBehaviour
{
    private void Awake () 
    {
        GetComponent<CharacterController>();
    }
 
 
     void Update () 
     {
 
         if (Input.GetKeyDown(KeyCode.Q))
         {
           ;
         }
 
         if (Input.GetKeyDown(KeyCode.D))
         {
            ;
         }

         if (Input.GetKeyDown(KeyCode.Space))
        {
             print("space key was pressed");
        }
     }
}   
