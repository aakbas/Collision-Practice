using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
  

  int score=0;
  
  

private void OnCollisionEnter(Collision other) {
    AddPoints();
}


  private void AddPoints(){
    score++;
    Debug.Log("Points : "+ score);
}



}
