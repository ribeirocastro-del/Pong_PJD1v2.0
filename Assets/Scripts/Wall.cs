using System;
using UnityEngine;

public class Wall : MonoBehaviour
{
    [SerializeField] private GameManeger GameManeger;
    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == "Ball")
        {
            if (CompareTag("IAWall"))
            {
               GameManeger.PlayerAddPoint(); 
               
            }

            if (CompareTag("PlayerWall"))
            {
               
                GameManeger.AIAddPoint();
            }
            
            other.gameObject.GetComponent<Ball>().ResetBall();
            
        }   
        
            
    }

}
