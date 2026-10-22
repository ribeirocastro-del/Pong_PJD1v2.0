using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerPaddle : MonoBehaviour

{
    
    [SerializeField] private float speed;

    private Vector2 directionInput;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        transform.Translate(Vector2.up * directionInput * speed * Time.deltaTime); 
    }
    
    public void OnMove (InputValue value)
    {
        directionInput = value.Get<Vector2>();
    }
    
}
/*
void: variavel sem valor, sem retorno 
vector2 dois pontos (x,y) < -x > x+ ,  y cima +   y baixo -
parametros; um valor local quer tem que ser prenchido 
get: pegar 
transforme e um component 
translate: valores do vetor 
Time.deltatime: a diferença entre os frames de pc bom e ruim 
speed: para que o jogador se mova mais rapido, pois (1,0) e lento 

*/