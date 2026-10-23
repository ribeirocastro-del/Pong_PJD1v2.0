using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField] private float ballSpeed;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Launch();
    }

    private void Launch()
    {
        Vector2 direction = Vector2.zero;
        
        if(Random.value <= 0.5f)
        {
            direction = Vector2.left;
        }
        else
        {
            direction = Vector2.right;
        }
        
        rb.linearVelocity =  direction * ballSpeed;
    }
}
/*
Ramdom: valores aleatorio 
value: valor 
antes do ponto, o que vem depois pertence ao antes 
top e down 
direction: direção
*/