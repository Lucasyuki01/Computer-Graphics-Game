using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.GraphicsBuffer;

public class Colisoes : MonoBehaviour{
    float pontos = 100;
    private Vector3 posicaoAnterior;
    //float velocidadeDeEntrada;
    public TextMeshProUGUI txtPontos;
    private bool tempoPontos = true;
    private bool tempoVelocidade = true;
    private float speed;
    public Rigidbody target;

    
    // Start is called before the first frame update
    public void Start(){
        posicaoAnterior = transform.position;
   }

    private void OnCollisionEnter(Collision collision){
        switch (collision.gameObject.tag){

            case "Cleitinho":

                Application.Quit();
                Debug.Log("Bateu");

                break;

            default:
                pontos = pontos - 5;
                //print("Bateu em alguma coisa");
                break;
        }
    }

    public void OnTriggerEnter(Collider other){
        switch (other.gameObject.tag){

           
                
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
        if(target.velocity.magnitude * 3.6f > 50)
        {
            if (tempoVelocidade)
            {
                pontos = pontos - 1;
                StartCoroutine(EsperarVelocidade());
                tempoVelocidade = !tempoVelocidade;
            }
        }

    }
    public void OnTriggerStay(Collider other) 
    {
        if (tempoPontos)
        {
            switch (other.gameObject.tag)
            {
                case "ColisorRuaX":
                    if (transform.position.x < posicaoAnterior.x)
                    {
                        Debug.Log("ERRADO");
                        pontos = pontos - 1;
                    }

                    posicaoAnterior = transform.position;
                    break;
                case "ColisorRua-X":
                    if (transform.position.x > posicaoAnterior.x)
                    {
                        Debug.Log("ERRADO");
                        pontos = pontos - 1;
                    }

                    posicaoAnterior = transform.position;
                    break;

                case "ColisorRuaZ":
                    if (transform.position.z < posicaoAnterior.z)
                    {
                        Debug.Log("ERRADO");
                        pontos = pontos - 1;
                    }

                    posicaoAnterior = transform.position;
                    break;

                case "ColisorRua-Z":
                    if (transform.position.z > posicaoAnterior.z)
                    {
                        Debug.Log("ERRADO");
                        pontos = pontos - 1;
                    }

                    posicaoAnterior = transform.position;
                    break;
            }
            tempoPontos = !tempoPontos;
            StartCoroutine(EsperarPontos());
        }
       
    }
    IEnumerator EsperarPontos()
    {

        yield return new WaitForSeconds(1);
        tempoPontos = !tempoPontos;
        


    }
    IEnumerator EsperarVelocidade()
    {

        yield return new WaitForSeconds(1);
        tempoVelocidade = !tempoVelocidade;



    }

    
}
   
// Calcular a velocidade de entrada
                //velocidadeDeEntrada = PrometeoCarController.carSpeed;
                // Agora, você pode usar a velocidade de entrada conforme necessário
                //Debug.Log($"Velocidade de entrada: {velocidadeDeEntrada}");