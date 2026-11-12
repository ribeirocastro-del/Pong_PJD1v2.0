using System;
using UnityEngine;

public class Wall : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == "Ball")
        {
            Debug.Log("Bateu na parede");
        }   
            
    }

}
