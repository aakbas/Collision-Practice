using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetect : MonoBehaviour
{
    
    

private void OnCollisionEnter(Collision other) {
    
    if  (other.gameObject.GetComponent<Mover>()){
           Debug.Log("Hit!");
    ColorChange();
    }
   

}

private void ColorChange(){

GetComponent<MeshRenderer>().material.color=Color.red;

}





}
