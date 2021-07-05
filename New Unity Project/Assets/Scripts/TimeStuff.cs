using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeStuff : MonoBehaviour
{
  
    [SerializeField] float dropTime=3;


    

    private void ActivateObjects(float activationTime){

        if(Time.time>=activationTime){

           GetComponent<Rigidbody>().useGravity=true;


        }


    }

     
      private void Update() {
         
        ActivateObjects(dropTime);

     }





}
