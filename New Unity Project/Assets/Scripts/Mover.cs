using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField] float moveSpeed=5;
    // Start is called before the first frame update
    void Start()
    {
       
        
    }



    // Update is called once per frame
    void Update()
    {
        float xValue=Input.GetAxis("Horizontal");
        float zValue=Input.GetAxis("Vertical");
        transform.Translate(xValue*moveSpeed*Time.deltaTime,0,zValue*moveSpeed*Time.deltaTime);
    }



}
