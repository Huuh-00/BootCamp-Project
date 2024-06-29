using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) {
            Console.WriteLine("Collided");
            print("Collided");
        }  
    }

    //private void OnCollisionStay(Collision collision)
    //{
        
    //}

    //private void OnCollisionExit(Collision collision)
    //{
        
    //}
}
