using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Colisoes : MonoBehaviour{
    float pontos = 100;
    private Vector3 posicaoAnterior;
    //float velocidadeDeEntrada;
    public TextMeshProUGUI txtPontos;

    
    // Start is called before the first frame update
    public void Start(){
        posicaoAnterior = transform.position;
   }

    private void OnCollisionEnter(Collision collision){
        switch (collision.gameObject.tag){
            default:
                pontos = pontos - 5;
                //print("Bateu em alguma coisa");
                break;
        }
    }

    public void OnTriggerEnter(Collider other){
        switch (other.gameObject.tag){

            case "ColisorRuaX":
                
            case "SinalVermelho":
                print("Passou no sinal vermelho");
                pontos = pontos - 5;
                break;

            case "ColisorCalcada":
                //print("Subiu na calçada");
                pontos = pontos -5;
                break;

            default:
                break;
        }
    }

    public void Update(){
        txtPontos.text = "Pontos: " + pontos;
        
        if (transform.position.x < posicaoAnterior.x){
                Debug.Log("ERRADO");
                pontos = pontos - 1;
            }
        
        posicaoAnterior = transform.position;
    }
}

// Calcular a velocidade de entrada
                //velocidadeDeEntrada = PrometeoCarController.carSpeed;
                // Agora, você pode usar a velocidade de entrada conforme necessário
                //Debug.Log($"Velocidade de entrada: {velocidadeDeEntrada}");